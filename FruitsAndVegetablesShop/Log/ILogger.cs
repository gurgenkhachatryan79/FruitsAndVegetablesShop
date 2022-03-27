using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitsAndVegetablesShop.Log
{
    interface ILogger
    {
        void LogError(string text);
        void LogInformation(string text);
    }
}
