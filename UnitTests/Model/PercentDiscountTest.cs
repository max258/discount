using System;
using Model;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    public class PercentDiscountTest
    {

        private PercentDiscount percentDiscount;
        [SetUp]
        public void RunBeforeTests()
        {
            percentDiscount = new PercentDiscount();
        }

        [TearDown]
        public void RunAfterTests()
        {
            percentDiscount = null;
        }
        /// <summary>
        /// Тестирование присваивания процента скидке
        /// </summary>
        /// <param name="percent"></param>
        [Test]
        [TestCase(1, TestName = "Тестирование Percent при присваивании 1.")]
        [TestCase(25, TestName = "Тестирование Percent при присваивании 25.")]
        [TestCase(50, TestName = "Тестирование Percent при присваивании 50.")]
        [TestCase(75, TestName = "Тестирование Percent при присваивании 75.")]
        [TestCase(100, TestName = "Тестирование Percent при присваивании 100.")]

        public void Percent_Test(int percent)
        {
            percentDiscount.Percent = percent;
        }

        [Test]
        [TestCase(101, TestName = "Тестирование Percent при присваивании 101.")]
        [TestCase(200, TestName = "Тестирование Percent при присваивании 200.")]
        [TestCase(0, TestName = "Тестирование Percent при присваивании 0.")]
        [TestCase(-1, TestName = "Тестирование Percent при присваивании -1.")]
        [TestCase(int.MinValue, TestName = "Тестирование Percent приприсваивании минимально допустимого целого числа.")]
        public void Percent_NegativeTest(int percent)
        {
            Assert.Throws(typeof(ArgumentException), () => { percentDiscount.Percent = percent; });
        }
        /// <summary>
        /// Тестирование расчета процентной скидки
        /// </summary>
        /// <param name="goodPrice"></param>
        /// <param name="percent"></param>
        /// <param name="expected"></param>
        [Test]
        [TestCase(1000.0, 20, 200.0, TestName = "Тестирование расчета скидки размером 20%")]
        [TestCase(2000.0, 50, 1000.0, TestName = "Тестирование расчета скидки размером 50%")]
        [TestCase(3000.0, 100, 3000.0, TestName = "Тестирование расчета скидки размером 100%")]
        [TestCase(4000.0, 10, 400, TestName = "Тестирование расчета скидки размером 10%")]


        public void GetDiscount_Test(double goodPrice, int percent, double expected)
        {
            var good = new Good(0, "Name", goodPrice, GoodCategory.Electronics);
            var discount = new PercentDiscount(0, percent, GoodCategory.Electronics);
            var actual = discount.GetDiscount(good);
            Assert.AreEqual(expected, actual);
        }
    }
}