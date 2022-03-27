﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitsAndVegetablesShop.Log
{
    public class Logger
    {
        string senttext;

        public void LogError(string text)
        {
            senttext = LogEnum.Error + " " + DateTime.Now + " " + text;
            new Writer().WriteText(senttext);
        }

        public void LogInformation(string text)
        {
            senttext = LogEnum.Information + " " + DateTime.Now + " " + text;
            new Writer().WriteText(senttext);
        }
    }
}