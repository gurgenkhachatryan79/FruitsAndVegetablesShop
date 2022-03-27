using FruitsAndVegetablesShop.Products;
using FruitsAndVegetablesShop.Products.Fruits;
using FruitsAndVegetablesShop.Products.Vegetables;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

namespace FruitsAndVegetablesShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shop shop = new Shop("GoodShop", "02247573", "Andraniki 44", "09:00", "21:00");
            ShopManager shopManager = new ShopManager(15, "Armen", 50);
            List<IProducts> products = new List<IProducts>()
            {
                new Apple( 1,"Golden",250,500,5),new Orange(2,"Small",650,200,10),
                new Tomato(3,"Armenian",500,100,7),new Cucumber(4,"Geogian",800,200,12)
            };
            //   shopManager.GetProductForShop(products);

            shop.GetProductForShop(products);
            new ShowInfo().Print(Shop.ProductsList);

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
