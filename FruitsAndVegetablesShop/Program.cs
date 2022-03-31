using FruitsAndVegetablesShop.Products;
using FruitsAndVegetablesShop.Products.Fruits;
using FruitsAndVegetablesShop.Products.Vegetables;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using Serilog;
using System.Threading;
using FruitsAndVegetablesShop.Serializer;

namespace FruitsAndVegetablesShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateSerilog();
            Shop shop = new Shop("GoodShop", "02247573", "Andraniki 44");
            ShopManager shopManager = new ShopManager(15, "Armen", 50);      
            List<IProducts> products = new List<IProducts>()
            {
                 new Apple( 1,"Golden",250,500),new Orange(2,"Small",650,200),
                 new Tomato(3,"Armenian",500,100),new Cucumber(4,"Geogian",800,200),
                 new Apple(1,"DDD",200,200)
            };
            shop.MakeProductForShop(products);
            // shopManager.GetProductForShop(products);

             CreateHostBuilder(args).Build().Run();
          

        }

        static void CreateSerilog()
        {
             Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("Log/myapp.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();  
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
