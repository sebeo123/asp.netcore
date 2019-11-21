using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreApp.Controllers
{   /*[Route("khachhang")]*/
    public class CustomerController : Controller
    {
        //[Route("vip")]
        public string Vip()
        {
            return "đây là khách hàng vip";
        }
        //[Route("")]
        [Route("normal/{id?}")]
        public string Nomarl(int id)
        {
            return "đây là khách hàng normal id=" +id;
        }
    }
}