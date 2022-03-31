using Serilog;
using System;

namespace FruitsAndVegetablesShop.Products
{
    public class Products : IProducts
    {
        int id;
        string productName;
        double price;
        double count;
        public int Id
        {
            set
            {
                if (value>0)
                {
                    id = value;
                }
                else
                {
                    Log.Error("Invalid Id");
                }
            }
            get
            {
                return id;
            }
        }
        public string ProductName
        {
            set
            {
                if (value.Length < 30 && value.Length > 0) { productName = value; }
                else { Log.Error("Invalid ProductName"); }
            }
            get
            {
                return productName;
            }
        }
        public double Price
        {
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    Log.Error("Invalid price");
                }
            }
            get
            {
                return price;
            }
        }
        public double Count {
            set
            {
                if (value > 0)
                {
                    count = value;
                }
                else
                {
                    Log.Error("Invalid count");
                }
            }
            get
            {
                return count;
            }
        }

        public Products(int id, string productName, double price, double count)
        {
            Id = id;
            ProductName = productName;
            Price = price;
            Count = count;
        }
    }
}
