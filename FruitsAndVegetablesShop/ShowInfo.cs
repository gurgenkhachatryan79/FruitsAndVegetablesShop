//using FruitsAndVegetablesShop.Log;
using FruitsAndVegetablesShop.Products;
using System;
using System.Collections.Generic;

namespace FruitsAndVegetablesShop
{
    public class ShowInfo
    {public void Print(List<IProducts> products)
        // public void Print(IProducts item)
        { 
             foreach (var item in products)
            {
                Console.WriteLine(item.Id + " " + item.ProductName + ".." + item.Price);
                Console.WriteLine("-----");
            }
        }
    }
}
