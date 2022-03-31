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
    public class ProductDeserialize
    {
        public static void ProductDeserializeMethod()
        {

            var pathDirectory = "DBfolder//Product//";
            var pathFile = Path.Combine(Environment.CurrentDirectory, pathDirectory, "productfile.txt");
            string restoredtext = null;
            List<IProducts> newList = null;
            try
            {
                using (StreamReader streamReader = new StreamReader(pathFile, System.Text.Encoding.Default))
                {
                    restoredtext = streamReader.ReadToEnd();
                };
                Console.WriteLine("restoredtext="+restoredtext);
                newList = JsonSerializer.Deserialize<List<IProducts>>(restoredtext);
                //new ShowInfo().Print(newList);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "FileNotFoundException");
            }
           // return newList;
        }

    }
}
