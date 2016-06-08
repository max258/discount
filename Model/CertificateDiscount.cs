using System;

namespace Discounts
{
    /// <summary>
    /// Скидка по сертификату
    /// </summary>
    public class CertificateDiscount : Discount, IDiscount
    {
        private string _description;
        private double _sum;
        
        /// <summary>
        /// Описание скидки
        /// </summary>
        public string Description
        {
            get
            {
                _description = _sum + " руб. " + Category;
                return _description;
            }
            set { }
        }

        // Сертификат применён
        public bool IsApplied { get; set; }

        /// <summary>
        /// Сумма, указанная в сертификате, которая вычитается из стоимости товара
        /// </summary>
        public double Sum
        {
            get { return _sum; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сумма сертификата должна быть положительной!");
                }
                _sum = value;
            }
        }

        /// <summary>
        /// Метод для расчета скидки
        /// </summary>
        /// <param name="good"> Товар для которого рассчитывается скидка </param>
        /// <returns> Возвращает размер скидки для данного товара </returns>
        public double GetDiscount(Good good)
        {
            if (Category != good.Category)  // Скидка не распространяется на этот товар
            {
                return 0;
            }
            if (_sum <= good.Cost) // Если сумма сертификата меньше стоимости товара
            {
                var sum = _sum;
                _sum = 0;
                IsApplied = true;
                return sum;
            }
            _sum = _sum - good.Cost;
            IsApplied = true;
            return good.Cost;   // Если сумма сертификата больше стоимости товара
        }
    }
}