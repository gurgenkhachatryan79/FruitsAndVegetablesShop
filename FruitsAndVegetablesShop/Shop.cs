using FruitsAndVegetablesShop.Products;
using FruitsAndVegetablesShop.Serializer;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;

namespace FruitsAndVegetablesShop
{
    public class Shop
    { 
        public string Name { set; get; }
        public string InnIndex { get; }
        public string Address { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
        public static List<IProducts> _productsList;
        public ShopManager Manager { get; set; }


        public Shop(string name, string innindex, string address, string openingTime, string closingTime)
        {
            Name = name;
            InnIndex = innindex;
            Address = address;
            OpeningTime = openingTime;
            ClosingTime = closingTime;
            _productsList = new List<IProducts>();
        }

        public void MakeProductForShop(List<IProducts> products)
        {
            _productsList.AddRange(products);           
            try
            {   
                 Log.Information("Starting web host");
                 ProductSerialize.PruductSerializeMethod(_productsList);
                 Thread.Sleep(1000);
                // ProductDeserialize.ProductDeserializeMethod();
                //List<IProducts> newlist = ProductDeserialize.ProductDeserializeMethod();
                //new ShowInfo().Print(newlist);

            }
            catch (Exception e)
            {
                Log.Error(e, "Something went wrong");
            }
        }


        public static List<IProducts> GetAllProducts()
        {
            if (_productsList == null)
            {
                Log.Information("Product list is null");
            }
            return _productsList;
        }
        public static IProducts GetProductByID(int id)
        {
            if (_productsList == null)
            {
                Log.Information("Product list is null");
            }
            IProducts pr = _productsList.SingleOrDefault(x => x.Id == id);
            if (pr == null) { Log.Information("Not found Idd"); }
            return pr;
        }

        public static void AddProduct(IProducts product)
        {
            _productsList.Add(product);
            // new ShowInfo().Print(Shop.ProductsList);
        }

        public static List<IProducts> DeleteProductByID(int id)
        {
            for (int i = 0; i < _productsList.Count; i++)
            {
                if (_productsList[i].Id == id)
                {
                    _productsList.RemoveAt(i);
                    break;
                }
            }
            return _productsList;
        }

      


    }
}
