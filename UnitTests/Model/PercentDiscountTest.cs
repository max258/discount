using System;
using Model;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    public class PercentDiscountTest
    {
        /// <summary>
        /// Тестирование присваивания процента скидке
        /// </summary>
        /// <param name="percent"></param>
        [Test]
        [TestCase(1, TestName = "Тестирование Percent при присваивании 1.")]
        [TestCase(100, TestName = "Тестирование Percent при присваивании 100.")]
        [TestCase(101, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Percent при присваивании 101.")]
        [TestCase(200, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Percent при присваивании 200.")]
        [TestCase(0, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Percent при присваивании 0.")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Percent при присваивании -1.")]
        [TestCase(int.MinValue, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Percent приприсваивании минимально допустимого целого числа.")]
        public void Percent_Test(int percent)
        {
            var percentDiscount = new PercentDiscount();
            percentDiscount.Percent = percent;
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