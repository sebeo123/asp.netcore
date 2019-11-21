using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class ProductController : Controller
    {
        public List<ProductModel> products = new List<ProductModel>()
        {
            new ProductModel(){id = 1,Name = "Product1",Available = true,Price = 10000, PromotionPrice = 8000},
            new ProductModel(){id = 2,Name = "Product2",Available = false,Price = 20000, PromotionPrice = 18000}
        };
        public IActionResult Index()
        {
            return View(products);
        }
        
    }
}