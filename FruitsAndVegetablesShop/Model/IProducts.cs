using System;

namespace FruitsAndVegetablesShop.Products
{
    public interface IProducts
    {
        public int Id { set; get; }
        public string ProductName { set; get; }
        //public DateTime ProductionPeriod { set; get; }
        //public DateTime ShelfԼife { set; get; }
        public double Price { set; get; }
        public double Count { set; get; }
    }
}
