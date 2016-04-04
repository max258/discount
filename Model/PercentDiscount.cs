using System;

namespace Model
{
    /// <summary>
    /// Процентная скидка
    /// </summary>
    public class PercentDiscount : IDiscount
    {
        private string _description;

        /// <summary>
        /// Категория товаров, на которую распространяется скидка
        /// </summary>
        public GoodCategory Category { get; set; }

        private GoodCategory _category;

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Description { get; set; }

        private int _percent; // Процент, вычитающийся из суммы товара

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


        public PercentDiscount()
        {
            _id = 0;
            _percent = 0;
            _category = GoodCategory.Electronics;
        }

        public PercentDiscount(int id ,int percent, GoodCategory category)
        {
            Id = id;
            Percent = percent;
            Category = category;
        }

        /// <summary>
        /// Метод для рассчета скидки
        /// </summary>
        /// <param name="good"> Товар для которого рассчитывается скидка </param>
        /// <returns> Возвращает размер скидки для данного товара </returns>
        public double GetDiscount(Good good)
        {
            if (Category != good.Category)
            {
                return 0;
            }
            return (good.Cost/100)*_percent;
        }

        public string FormDescription()
        {
            _description = _percent + "% " + Category;
            return _description;
        }
    }
}