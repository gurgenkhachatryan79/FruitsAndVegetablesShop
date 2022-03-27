using FruitsAndVegetablesShop.Products;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FruitsAndVegetablesShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<IProducts> Get()
        {
            return Shop.GetProducts();
        }
        [HttpGet("{id}")]
        public IProducts GetID(int id)
        {
            return Shop.GetProductID(id);
        }

        [HttpPost]
        public void Post([FromBody] IProducts products)
        {
            Shop.AddProduct(products);
        }


    }
}
