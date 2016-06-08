using System;

namespace Discounts
{
    /// <summary>
    /// Товар
    /// </summary>
    public class Good
    {
        private int _id;
        private double _cost;

        /// <summary>
        /// Категория товара
        /// </summary>
        public GoodCategory Category { get; set; }

        /// <summary>
        /// Стоимость товара
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Неверно указана цена!");
                }
                _cost = value;
            }
        }

        /// <summary>
        /// Номер товара
        /// </summary>
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
        /// Название товара
        /// </summary>
        public string Name { get; set; }
    }
}