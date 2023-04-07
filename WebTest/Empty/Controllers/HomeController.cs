using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Empty.Models;

namespace Empty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            MessageTest msg = new MessageTest()
            {
                Message = "Welcome to Asp.Net MVC !"
            };

            ViewBag.Noti = "input message and click submit";

            return View(msg);
        }

        //POST를 처리하는 index
        [HttpPost]
        public IActionResult Index(MessageTest obj)
        {
            ViewBag.Noti = "Message Changed";
            return View(obj);
        }
    }
}
