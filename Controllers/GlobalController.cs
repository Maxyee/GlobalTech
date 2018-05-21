using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GlobalTech.Controllers
{
    public class GlobalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}