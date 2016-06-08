using System;
using Discounts;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    public class CertificateDiscountTest
    {
        /// <summary>
        /// Тестирование присваивания суммы сертификата
        /// </summary>
        /// <param name="sum"></param>
        [Test]
        [TestCase(1, TestName = "Тестирование Sum при присваивании 1.")]
        [TestCase(100, TestName = "Тестирование Sum при присваивании 100.")]
        [TestCase(2999.99, TestName = "Тестирование Sum при присваивании 2999.9.")]
        [TestCase(double.MaxValue, TestName = "Тестирование Sum при присваивании double.MaxValue.")]

        public void Sum_Test(double sum)
        {
            var certificateDiscount = new CertificateDiscount();
            certificateDiscount.Sum = sum;
        }
        [Test]
        [TestCase(0, TestName = "Тестирование Sum при присваивании 0.")]
        [TestCase(-0.01, TestName = "Тестирование Sum при присваивании -0.01.")]
        [TestCase(-1, TestName = "Тестирование Sum при присваивании -1.")]
        [TestCase(-1000, TestName = "Тестирование Sum при присваивании -1000.")]
        [TestCase(double.MinValue, TestName = "Тестирование Sum приприсваивании минимально допустимого числа.")]

        public void Percent_NegativeTest(double sum)
        {
            var certificateDiscount = new CertificateDiscount();

            Assert.Throws(typeof(ArgumentException), () => { certificateDiscount.Sum = sum; });
        }

        /// <summary>
        /// Тестирование присваивания номера
        /// </summary>
        /// <param name="id"></param>
        [Test]
        [TestCase(1, TestName = "Тестирование Id при присваивании 1.")]
        [TestCase(100, TestName = "Тестирование Id при присваивании 100.")]
        [TestCase(int.MaxValue, TestName = "Тестирование Id при присваивании int.MaxValue.")]
        public void Id_Test(int id)
        {
            var certificateDiscount = new CertificateDiscount();
            certificateDiscount.Id = id;
        }
        [Test]
        [TestCase(-1, TestName = "Тестирование Id при присваивании -1.")]
        [TestCase(int.MinValue, TestName = "Тестирование Id приприсваивании минимально допустимого целого числа.")]
        public void Id_NegativeTest(int id)
        {
            var certificateDiscount = new CertificateDiscount();
            Assert.Throws(typeof(ArgumentException), () => { certificateDiscount.Id = id; });
        }

        /// <summary>
        /// Тестирование расчета скидки по сертификату
        /// </summary>
        /// <param name="goodPrice"></param>
        /// <param name="discountValue"></param>
        /// <param name="expected"></param>
        [Test]
        [TestCase(1000.0, 1000.0, 1000.0, TestName = "Товар - 1000 руб., скидка - 1000 руб.")]
        [TestCase(2000.0, 500.0, 500.0, TestName = "Товар - 2000 руб., скидка - 500 руб.")]
        [TestCase(3000.0, 5000.0, 3000.0, TestName = "Товар - 3000 руб., скидка - 5000 руб.")]
        [TestCase(4000.0, 100, 100, TestName = "Товар - 4000 руб., скидка - 100 руб.")]
        [TestCase(5000.0, 10000.0, 5000.0, TestName = "Товар - 5000 руб., скидка - 10000 руб.")]

        public void GetDiscount_Test(double goodPrice, double discountValue, double expected)
        {
            var good = new Good();
            good.Id = 0;
            good.Name = "";
            good.Cost = goodPrice;
            good.Category = (GoodCategory) 1;
            var discount = new CertificateDiscount();
            discount.Id = 0;
            discount.Sum = discountValue;
            discount.Category = (GoodCategory) 1;
            var actual = discount.GetDiscount(good);
            Assert.AreEqual(expected, actual);
        }
    }
}