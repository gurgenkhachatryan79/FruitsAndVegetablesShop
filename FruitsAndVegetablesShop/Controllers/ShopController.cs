//using FruitsAndVegetablesShop.Products;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FruitsAndVegetablesShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value3", "value4" };
        }
    }
}
