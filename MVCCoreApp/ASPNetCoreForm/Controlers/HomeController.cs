using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreForm.Controlers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
           
            return View();
        }

        public IActionResult Edit()
        {
            var model = new ProductEditModel();
            model.Name = "test";
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(ProductEditModel model)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                //check product name exist
                if (model.Name == "hacker")
                {
                    ModelState.AddModelError("","This product name was existed");
                    return View(model);
                }
                message = "Product: " + model.Name + ". Rate: " + model.Rate + ". Rating: " + model.Rating +
                          " Created succesfully";
            }
            else
            {
                return View(model);
            }
            return Content(message);
        }

        [HttpGet]
        public IActionResult FormAndQuery()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormAndQuery(string name, ProductEditModel model)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                message = "Query string " + name + " product " + model.Name + " Rate " + model.Rate + " Rating " +
                          model.Rating;
            }
            else
            {
                message = "Failed to create the product. please try again";
            }

            return Content(message);
        }
    }
}