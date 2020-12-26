using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Controllers
{
    public class TableMainMenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
