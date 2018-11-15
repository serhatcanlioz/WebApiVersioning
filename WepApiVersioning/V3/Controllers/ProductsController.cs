using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApiVersioning.V3.Model;

namespace WepApiVersioning.V3.Controllers
{
    [ApiVersion("3.0-Alpha")]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            Product product=new Product
            {
                ProductId = 3,
                CategoryId = 3,
                ProductName = "Product3",
                UnitPrice = 3
            };
            return Ok(product);
        }
    }
}