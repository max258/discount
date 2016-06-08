using System;

namespace Discounts
{
    public abstract class Discount
    {
        private int _id;

        /// <summary>
        /// Категория товаров, на которую распространяется скидка
        /// </summary>
        public GoodCategory Category { get; set; }

        /// <summary>
        /// Номер скидки
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
    }
}