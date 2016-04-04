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

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private double _cost; // Стоимость товара
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Good()
        {
            _id = 0;
            _cost = 0;
            _category = GoodCategory.Electronics;
        }

        public Good(int id, string name, int cost, GoodCategory category)
        {
            Id = id;
            Name = name;
            Cost = cost;
            Category = category;
        }

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
    }
}