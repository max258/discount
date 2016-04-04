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

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _description;
        public string Description { get; set; }

        public CertificateDiscount()
        {
            _id = 0;
            _sum = 0;
            _category = GoodCategory.Electronics;
        }

        public CertificateDiscount(int id, int sum, GoodCategory category)
        {
            Id = id;
            Sum = sum;
            Category = category;
        }
       
        private int _sum; // Сумма, указанная в сертификате, которая вычитается из стоимости товара

        /// <summary>
        /// Сумма, указанная в сертификате, которая вычитается из стоимости товара
        /// </summary>
        public int Sum
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
            if (Category != good.Category)  // Проверка соответствия категорий скидки и товара
            {
                return 0;
            }
            if (_sum <= good.Cost) // Если сумма не полностью покрывает стоимость товара
            {
                return _sum;
            }
            return good.Cost;   // Если сумма покрывает стоимость товара полностью
        }

        public string FormDescription()
        {
            _description = _sum + " руб. " + Category;
            return _description;
        }
    }
}