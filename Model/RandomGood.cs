using System;

namespace Discounts
{
    public class RandomGood
    {
        private string[] electronic = { "ASUS X550L", "ZTE Nubia Z7", "IPhone 4S", "Nokia C6-01", "Nokia 3310", "OnePlus One" };
        private string[] food = { "Bread", "Pepsi", "Milk", "Snickers", "Chicken", "Eggs" };
        private string[] cosmetic = { "Red lipstic", "Black lipstic", "Blue hair dye", "Brown hair dye", "Perfume", "Nail polish" };
        private string[] chemistry = { "Mr. Proper", "Soap", "Ariel", "Fairy", "Bref", "Domestos" };
        private string[] clothes = { "Blue shirt", "Red dress", "Black skirt", "Grey jacket", "Jeans", "Black hat" };

        public Good Good
        {
            get
            {
                Good randomGood = new Good();
                var random = new Random();
                int category = random.Next(5);
                switch (category)
                {
                    case 0:
                        randomGood.Category = GoodCategory.Electronics;
                        randomGood.Name = electronic[random.Next(6)];
                        randomGood.Cost = random.Next(3000, 50000);
                        randomGood.Id = 0;
                        break;
                    case 1:
                        randomGood.Category = GoodCategory.Food;
                        randomGood.Name = food[random.Next(6)];
                        randomGood.Cost = random.Next(50, 600);
                        randomGood.Id = 0;
                        break;
                    case 2:
                        randomGood.Category = GoodCategory.Cosmetic;
                        randomGood.Name = cosmetic[random.Next(6)];
                        randomGood.Cost = random.Next(1000, 3000);
                        randomGood.Id = 0;
                        break;
                    case 3:
                        randomGood.Category = GoodCategory.Chemistry;
                        randomGood.Name = chemistry[random.Next(6)];
                        randomGood.Cost = random.Next(50, 500);
                        randomGood.Id = 0;
                        break;
                    case 4:
                        randomGood.Category = GoodCategory.Clothes;
                        randomGood.Name = clothes[random.Next(6)];
                        randomGood.Cost = random.Next(2000, 10000);
                        randomGood.Id = 0;
                        break;
                }
                return randomGood;
            }
        }
    }
}