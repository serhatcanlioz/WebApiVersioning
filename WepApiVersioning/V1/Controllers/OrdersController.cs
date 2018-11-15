using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApiVersioning.V1.Models;

namespace WepApiVersioning.V1.Controllers
{
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            Order order=new Order
            {
                OrderDate = DateTime.Now,
                OrderId = 1,
                ProductId = 1
            };
            return Ok(order);
        }
    }
}