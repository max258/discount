using System;
using Discounts;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    public class GoodTest
    {
        /// <summary>
        /// Тестирование присваивания стоимости товару
        /// </summary>
        /// <param name="cost"></param>
        [Test]
        [TestCase(1, TestName = "Тестирование Cost при присваивании 1.")]
        [TestCase(0.50, TestName = "Тестирование Cost при присваивании 0.50.")]
        [TestCase(100, TestName = "Тестирование Cost при присваивании 100.")]
        [TestCase(1000, TestName = "Тестирование Cost при присваивании 1000.")]
        [TestCase(9999.99, TestName = "Тестирование Cost при присваивании 9999.99.")]
        [TestCase(double.MaxValue, TestName = "Тестирование Cost при присваивании double.MaxValue.")]
        
        public void Cost_Test(double cost)
        {
            var good = new Good();
            good.Id = 0;
            good.Name = "";
            good.Cost = 0;
            good.Category = (GoodCategory)1;
            good.Cost = cost;
        }
        [Test]
        [TestCase(-1, TestName = "Тестирование Cost при присваивании -1.")]
        [TestCase(-0.01, TestName = "Тестирование Cost при присваивании -0.01.")]
        [TestCase(double.MinValue, TestName = "Тестирование Cost при присваивании double.MinValue.")]
        public void Cost_NegativeTest(double cost)
        {
            var good = new Good();
            Assert.Throws(typeof(ArgumentException), () => { good.Cost = cost; });
        }

        /// <summary>
        /// Тестирование присваивания категории
        /// </summary>
        /// <param name="category"></param>
        [Test]
        [TestCase(GoodCategory.Electronics, TestName = "Тестирование Category при присваивании Electronics.")]
        [TestCase(GoodCategory.Chemistry, TestName = "Тестирование Category при присваивании Chemistry.")]
        [TestCase(GoodCategory.Clothes, TestName = "Тестирование Category при присваивании Clothes.")]
        [TestCase(GoodCategory.Cosmetic, TestName = "Тестирование Category при присваивании Cosmetic.")]
        [TestCase(GoodCategory.Food, TestName = "Тестирование Category при присваивании Food.")]

        
        public void Category_Test(GoodCategory category)
        {
            var good = new Good();
            good.Category = category;
            Assert.IsInstanceOf(typeof(GoodCategory), category);
        }

        /// <summary>
        /// Тестирование присваивания названия
        /// </summary>
        /// <param name="name"></param>
        [Test]
        [TestCase("Nokia 3310", TestName = "Тестирование Name при присваивании строки.")]
        [TestCase("Snickers", TestName = "Тестирование Name при присваивании строки.")]
        [TestCase(5, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Name при присваивании числа.")]

        public void Name_Test(string name)
        {
            var good = new Good();
            good.Name = name;
        }
    }
}