using System;
using System.Collections.Generic;
using Model;

namespace ConsoleLoader
{
    class Program
    {
        static void Main()
        {
            try
            {
                var list = new List<IDiscount>();
                var goodList = new List<Good>();

                var discount1 = new PercentDiscount();
                discount1.Percent = 20;
                discount1.Category = GoodCategory.Clothes;
                list.Add(discount1);

                var discount2 = new CertificateDiscount();
                discount2.Sum = 2000;
                discount2.Category = GoodCategory.Electronics;
                list.Add(discount2);

                var good1 = new Good();
                good1.Cost = 5000;
                good1.Category = GoodCategory.Clothes;
                goodList.Add(good1);

                var good2 = new Good();
                good2.Cost = 10000;
                good2.Category = GoodCategory.Electronics;
                goodList.Add(good2);

                var good3 = new Good();
                good3.Cost = 1500;
                good3.Category = GoodCategory.Electronics;
                goodList.Add(good3);

                var good4 = new Good();
                good4.Cost = 1999;
                good4.Category = GoodCategory.Clothes;
                goodList.Add(good4);

                foreach (IDiscount discount in list)
                {
                    Console.WriteLine(discount.FormDescription());
                    Console.WriteLine();
                    foreach (Good good in goodList)
                    {
                        Console.WriteLine("Скидка на товар стоимостью {0} рублей из категории {1} составляет {2} рублей", good.Cost, good.Category,
                            discount.GetDiscount(good));
                        Console.WriteLine();
                    }
                }

                Console.ReadLine();
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadLine();
            }
        }

    }
}
