using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitsAndVegetablesShop.Products.Fruits
{
    public class Apple:IFruits
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public DateTime ProductionPeriod { get; set; }
        public DateTime ShelfԼife { get; set; }
        public double Price { get; set; }
        public double Count { get; set; }

        public Apple(int id, string productName, double price, double count, int shelflife)
        {
            Id = id;
            ProductName = productName;
            Price = price;
            Count = count;
            ProductionPeriod = DateTime.Now;
            ShelfԼife = ProductionPeriod.AddDays(shelflife);
        }
    }
}
