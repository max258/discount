using System;

namespace Model
{
    /// <summary>
    /// Описание товара
    /// </summary>
    public class Good
    {
        /// <summary>
        /// Описание категории товара
        /// </summary>
        public GoodCategory Category { get; set; }

        private GoodCategory _category;

        private int _id;

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
        /// Стоимость товара
        /// </summary>
        private double _cost;

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
        /// Название товара
        /// </summary>
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Good()
        {
            _id = 0;
            _cost = 0;
            _category = GoodCategory.Electronics;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="id">Номер</param>
        /// <param name="name">Название</param>
        /// <param name="cost">Стоимость</param>
        /// <param name="category">Категория</param>
        public Good(int id, string name, double cost, GoodCategory category)
        {
            Id = id;
            Name = name;
            Cost = cost;
            Category = category;
        }


    }
}