using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcLayout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Greeting"] = "Hello World";
            ViewBag.Greeting = "Hello Viewbag";
            ViewData["Product"] = new ProductModel()
            {
                Id = 1,
                Name = "TEDU",
                Brand = "TEDU",
                Price = 10000

            };
            ViewBag.Product = new ProductModel()
            {
                Id = 1,
                Name = "TEDU",
                Brand = "TEDU",
                Price = 10000

            };
            return View();
        }
    }
}