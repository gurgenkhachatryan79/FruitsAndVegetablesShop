using FruitsAndVegetablesShop.Products;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace FruitsAndVegetablesShop.Serializer
{
    public class ProductSerialize
    {
        public static void PruductSerializeMethod(List<IProducts> products)
        {
            var pathDirectory = "DBfolder//Product//";
            var pathFile = Path.Combine(Environment.CurrentDirectory, pathDirectory, "productfile.txt");
            DirectoryInfo directoryInfo = new DirectoryInfo(pathDirectory);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            try
            {
                string jsonproductlist = JsonSerializer.Serialize(products);
                using (StreamWriter streamWriter = new StreamWriter(pathFile))
                {
                    streamWriter.WriteLine(jsonproductlist);
                    Log.Information("Text send in file");
                };
            }
            catch (FileNotFoundException e) { Log.Error(e, "FileNotFoundException"); }
            catch (DirectoryNotFoundException d) { Log.Error(d, "DirectoryNotFoundException"); }

        }
    }
}
