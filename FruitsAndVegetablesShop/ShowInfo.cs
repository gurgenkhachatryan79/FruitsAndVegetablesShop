using FruitsAndVegetablesShop.Log;
using FruitsAndVegetablesShop.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitsAndVegetablesShop
{
    public class ShowInfo
    {
        public void Print(List<IProducts> products)
        {
            foreach (var item in products)
            {
                string text = $"Product:{item.GetType().Name}\nID: {item.Id}\nProductType: {item.ProductName}\nCount:{item.Count} ProductionPeriod {item.ProductionPeriod} \nShelfԼife:{item.ShelfԼife}\nPrice:{item.Price}{new string('-', 40)}";
                Console.WriteLine("Product=" + item.GetType().Name + "\nID:" + item.Id + "\nProductType:" + item.ProductName + "\nCount:" + item.Count);
                Console.WriteLine("ProductionPeriod:" + item.ProductionPeriod + "\nShelfԼife:" + item.ShelfԼife + "\nPrice:" + item.Price);
                Console.WriteLine(new string('-', 40));
                new Logger().LogInformation(text);
            }
        }
    }
}
