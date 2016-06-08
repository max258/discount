using System;
using System.Collections.Generic;

namespace Discounts
{
    public class RandomDiscount
    {
        public IDiscount Discount
        {
            get {
                var random = new Random();
                GoodCategory category = (GoodCategory)random.Next(1, 5);
                int discountType = random.Next(2);

                if (discountType == 0)
                {
                    int percent = random.Next(1, 100);
                    PercentDiscount randomDiscount = new PercentDiscount();
                    randomDiscount.Id = 0;
                    randomDiscount.Percent = percent;
                    randomDiscount.Category = category;
                    return randomDiscount;
                }
                else
                {
                    double sum = random.Next(10000);
                    CertificateDiscount randomDiscount = new CertificateDiscount();
                    randomDiscount.Id = 0;
                    randomDiscount.Sum = sum;
                    randomDiscount.Category = category;
                    randomDiscount.IsApplied = false;
                    return randomDiscount;
                }
            }  
        } 
    }
}