using System;
using System.IO;

namespace FruitsAndVegetablesShop.Log
{
    public class Writer
    {
        public void WriteText(string text)
        {
            string pathFolder = "Log//Message//";

            string pathfile = pathFolder + "file.txt";
            DirectoryInfo directoryInfo = new DirectoryInfo(pathFolder);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(pathfile, true))
                {
                    streamWriter.WriteLine(text);
                };
            }
            catch (FileNotFoundException fnf) { Console.WriteLine(fnf.Message); }
            catch (DirectoryNotFoundException dnf) { Console.WriteLine(dnf.Message); }

        }
    }
}