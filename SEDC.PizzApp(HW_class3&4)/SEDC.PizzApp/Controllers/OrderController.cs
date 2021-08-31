using Microsoft.AspNetCore.Mvc;
using SEDC.PizzApp.Models;

namespace SEDC.PizzApp.Controllers
{
    //[Route("Custom/[Action]")]
    public class OrderController : Controller
    {
        public IActionResult RazorOrder()
        {
            var person = new User
            {
                Address = "Adresa",
                FirstName = "John",
                LastName = "Doe",
                Phone = 123123123
            };

            var order = new Order
            {
                Id = 10,
                Pizza = "Kapriciosa",
                Price = 300,
                User = person,
                Delivered = false
            };

            return View(order);
        }

        public IActionResult Index()
        {
            return View();
        }

        // ViewResult
        public IActionResult Order()
        {
            return View("Order2");
        }

        // EmptyResult
        public IActionResult Empty()
        {
            return new EmptyResult();
        }

        // RedirectResult
        public IActionResult Order2(int? id)
        {
            if (id.HasValue)
            {
                return View();
            }

            return RedirectToAction("Order");
        }

        // RedirectResult in another controller
        [Route("Order/GetOrder/{id}")]
        public IActionResult Order3(int id)
        {
            return RedirectToAction("Privacy", "Home");
        }

        // JsonResult
        public IActionResult JsonResult()
        {
            var json = new { Id = 2, Name = "JSON" };

            return new JsonResult(json);
        }

        // CUSTOM ROUTE
        [HttpGet("Get/All/Users")]
        public IActionResult GetAllUsersFromUserIdAndSetupId(int? userId)
        {
            return View("Order2");
        }

        public IActionResult Helpers()
        {
            var person = new User
            {
                Address = "Adresa",
                FirstName = "John",
                LastName = "Doe",
                Phone = 123123123
            };

            var order = new Order
            {
                Id = 10,
                Pizza = "Kapriciosa",
                Price = 300,
                User = person,
                Delivered = false,
                Size = Enums.Size.Small
            };

            return View(order);
        }

        //(============================= Homework 3 =============================)

        [HttpGet("/OrderDetails/{id}")]
        public IActionResult GetOrderDetails(int id)
        {
            var person2 = new User
            {
                Address = "Poppy Fields 2",
                FirstName = "Gligor",
                LastName = "Gjurchevski",
                Phone = 38978464553
            };

            var order2 = new Order
            {
                Id = 32,
                Pizza = "Napolitana",
                Price = 300,
                User = person2,
                Delivered = false
            };
            return View();

        }
        //(============================= Homework 4 =============================)

        [HttpGet]
        public IActionResult Registration()
        {
            var orderNew = new NewOrderViewModel();

            return View(orderNew);
        }

        [HttpPost]
        public IActionResult Registration(NewOrderViewModel newOrder)
        {
            return View();
        }
    }
}
