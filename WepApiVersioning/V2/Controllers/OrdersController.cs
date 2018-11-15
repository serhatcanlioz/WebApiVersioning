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
    public class OrdersController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            Order order=new Order
            {
                ProductId = 2,
                OrderId = 2,
                OrderDate = DateTime.Now,
                ShipAddress = "Address2",
                ShipName = "Ship2"
            };
            return Ok(order);
        }
    }
}