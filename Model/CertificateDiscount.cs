using System;

namespace Model
{
    /// <summary>
    /// Скидка по сертификату
    /// </summary>
    public class CertificateDiscount : IDiscount
    {
        /// <summary>
        /// Категория товаров, на которую распространяется скидка
        /// </summary>
        public GoodCategory Category { get; set; }

        private GoodCategory _category;

        /// <summary>
        /// Скидка применена
        /// </summary>
        private bool _isApplied;

        public bool IsApplied
        {
            get { return _isApplied; }
            set { _isApplied = value; }
        }

        /// <summary>
        /// Номер скидки
        /// </summary>
        private int _id;

        public int Id
        {
            get { return _id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Номер должен быть положительным!");
                }
                _id = value;
            }
        }

        /// <summary>
        /// Описание скидки
        /// </summary>
        private string _description;
        public string Description { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public CertificateDiscount()
        {
            _id = 0;
            _sum = 0;
            _category = GoodCategory.Electronics;
            _isApplied = false;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="id">Номер</param>
        /// <param name="sum">Сумма</param>
        /// <param name="category">Категория</param>
        public CertificateDiscount(int id, double sum, GoodCategory category)
        {
            Id = id;
            Sum = sum;
            Category = category;
            IsApplied = false;
        }
       
        private double _sum; // Сумма, указанная в сертификате, которая вычитается из стоимости товара

        /// <summary>
        /// Сумма, указанная в сертификате, которая вычитается из стоимости товара
        /// </summary>
        public double Sum
        {
            get { return _sum; }
            set
            {
                if (value < 1)
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
                _isApplied = true;
                return sum;
            }
            _sum = _sum - good.Cost;
            _isApplied = true;
            return good.Cost;   // Если сумма сертификата больше стоимости товара
        }

        /// <summary>
        /// Получить описание скидки
        /// </summary>
        public string GetDescription()
        {
            _description = _sum + " руб. " + Category;
            return _description;
        }
    }
}