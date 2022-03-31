//using FruitsAndVegetablesShop.Products;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

using FruitsAndVegetablesShop.Products;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FruitsAndVegetablesShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<IProducts> Get()
        {
            return Shop.GetAllProducts();
        }
        [HttpGet("{id}")]
        public IProducts GetID(int id)
        {
            return Shop.GetProductByID(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] IProducts product)
        {
            Shop.AddProduct(product);
            System.Console.WriteLine(product.ToString());
            return this.Ok();
        }
    }
}
