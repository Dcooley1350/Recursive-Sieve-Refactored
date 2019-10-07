using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecursiveSieve.Models;

namespace RecursiveSieve.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }
        
        [Route("/Return")]
        public IActionResult Return()
        {
            return View();
        }
    }
}
