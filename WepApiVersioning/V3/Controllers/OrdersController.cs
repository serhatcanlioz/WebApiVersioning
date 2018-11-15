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
    public class OrdersController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            Order order=new Order
            {
                ProductId = 3,
                OrderId = 3,
                OrderDate = DateTime.Now,
                ShipName = "Ship3"
            };
            return Ok(order);
        }
    }
}