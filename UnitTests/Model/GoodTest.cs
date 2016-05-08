using System;
using Model;
using NUnit.Framework;

namespace UnitTests.Model
{
    public class GoodTest
    {
        /// <summary>
        /// Тестирование присваивания стоимости товару
        /// </summary>
        /// <param name="cost"></param>
        [Test]
        [TestCase(1, TestName = "Тестирование Cost при присваивании 1.")]
        [TestCase(100, TestName = "Тестирование Cost при присваивании 100.")]
        [TestCase(double.MaxValue, TestName = "Тестирование Cost при присваивании double.MaxValue.")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Cost при присваивании -1.")]
        [TestCase(double.MinValue, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Cost приприсваивании минимально допустимого числа.")]
        public void Cost_Test(double cost)
        {
            var good = new Good();
            good.Cost = cost;
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