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
                    throw new ArgumentException("Номер должен быть положмиельным!");
                }
                _id = value;
            }
        }
        /// <summary>
        /// Описание скидки
        /// </summary>
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

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PercentDiscount()
        {
            _id = 0;
            _percent = 0;
            _category = GoodCategory.Electronics;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="id">Номер</param>
        /// <param name="percent">Процент</param>
        /// <param name="category">Категория</param>
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

        /// <summary>
        /// Получить описание скидки
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            _description = _percent + "% " + Category;
            return _description;
        }
    }
}