using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentNHibernate.Data;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NHibernate;
using RestaurantApp.Constants;
using RestaurantApp.Entities;
using RestaurantApp.Helpers;
using RestaurantApp.Models;

namespace RestaurantApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> log;
        private UserDataHelper userDataHelper;

        public HomeController(ILogger<HomeController> logger)
        {
            log = logger;
            userDataHelper = new UserDataHelper();
        }

        public IActionResult Index()
        {
            return RedirectToAction("LogIn");
        }

        public IActionResult LogIn()
        {      
            return View();
        }

        [HttpPost]
        public IActionResult LogInAuthentication(string password)
        {
            log.LogInformation("Logging in user {0}", password);
            var userEntity = userDataHelper.GetUserData(password);
            if (userEntity == null)
            {
                log.LogInformation("Log in failed for password {0}", password);
                return Json(new { success = false });
            }
            else
            {
                log.LogInformation("Log in success for user {0}", userEntity.UserName);
                TempData[SessionConstants.USER_INFORMATION] = userEntity.UserName;
                return Json(new { success = true });
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
