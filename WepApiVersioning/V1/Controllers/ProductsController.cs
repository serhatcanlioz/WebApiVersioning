using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApiVersioning.V1.Models;

namespace WepApiVersioning.V1.Controllers
{
    [ApiVersion("1.0", Deprecated = true )]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            Product product=new Product
            {
                ProductId = 1,
                CategoryId = 1,
                ProductName = "Product1"
            };
            return Ok(product);
        }
    }
}