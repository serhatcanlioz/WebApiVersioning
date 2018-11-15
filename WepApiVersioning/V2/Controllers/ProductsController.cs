using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApiVersioning.V2.Models;

namespace WepApiVersioning.V2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            Product product=new Product
            {
                ProductId = 2,
                CategoryId = 2,
                ProductName = "Product2",
                UnitInStock = 2,
                UnitPrice = 2
            };
            return Ok(product);
        }
    }
}