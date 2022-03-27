using FruitsAndVegetablesShop.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitsAndVegetablesShop
{
    public class Shop
    {
        public string Name { set; get; }
        public string InnIndex { get; }
        public string Address { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
        public List<IProducts> ProductsList;
        public ShopManager Manager { get; set; }


        public Shop(string name, string innindex, string address, string openingTime, string closingTime)
        {
            Name = name;
            InnIndex = innindex;
            Address = address;
            OpeningTime = openingTime;
            ClosingTime = closingTime;
            ProductsList = new List<IProducts>();
        }

        public void GetProductForShop(List<IProducts> products)
        {
            ProductsList.AddRange(products);
        }


    }
}
