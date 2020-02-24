using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CA_hikingProject.Controllers
{
    public class ToursController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}