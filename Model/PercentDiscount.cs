using System;

namespace Discounts
{
    /// <summary>
    /// Процентная скидка
    /// </summary>
    public class PercentDiscount : Discount, IDiscount
    {
        private string _description;
        private int _percent;

        /// <summary>
        /// Описание скидки
        /// </summary>
        public string Description
        {
            get
            {
                _description = _percent + "% " + Category;
                return _description;
            }
            set { }
        }

        /// <summary>
        /// Процент, вычитающийся из суммы товара
        /// </summary>
        public int Percent
        {
            get { return _percent; }
            set
            {
                if ((value < 1) || (value > 100))
                {
                    throw new ArgumentException("Неверно указана скидка!");
                }       
                _percent = value;
            }
        }

        /// <summary>
        /// Метод для расчета скидки
        /// </summary>
        /// <param name="good"> Товар для которого рассчитывается скидка </param>
        /// <returns> Возвращает размер скидки для данного товара </returns>
        public double GetDiscount(Good good)
        {
            if (Category != good.Category)
            {
                return 0;
            }
            return (good.Cost / 100) * _percent;
        }
    }
}