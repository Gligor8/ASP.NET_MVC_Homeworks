using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp_HW.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/OrderDetails/{id}")]
        public IActionResult GetOrderDetails(int id)
        {

            return View();
        }
    }
}
