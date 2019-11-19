using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {

        //HttpContext ctx;

        //public HomeController(IHttpContextAccessor _ctx)
        //{
        //    ctx = _ctx.HttpContext;
        //}
        public IActionResult Index(string id)
        {
            var model = new IndexModel();
            model.Message = "homecontroller Hello my name tuan anh id=" + id;
            return View(model);
        }

        //public IActionResult Index()
        //{
        //    return Content("Hello tuan anh dep trai");
        //}
    }
}