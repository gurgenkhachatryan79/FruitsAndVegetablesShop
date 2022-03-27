using FruitsAndVegetablesShop.Products;
using System.Collections.Generic;
using System.Linq;

namespace FruitsAndVegetablesShop
{
    public class Shop
    {
        public string Name { set; get; }
        public string InnIndex { get; }
        public string Address { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
        public static List<IProducts> ProductsList;
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

        public static List<IProducts> GetProducts()
        {
            return ProductsList.ToList();
        }
        public static IProducts GetProductID(int id)
        {
            return ProductsList[id];
        }

        public static void AddProduct(IProducts product)
        {
            ProductsList.Add(product);
        }

        public static List<IProducts> DeleteProductByID(int id)
        {
            for (int i = 0; i < ProductsList.Count; i++)
            {
                if (ProductsList[i].Id == id)
                {
                    ProductsList.RemoveAt(i);
                    break;
                }
            }
            return ProductsList;
        }



    }
}
