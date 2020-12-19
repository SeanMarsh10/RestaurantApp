using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantApp.Helpers;

namespace RestaurantApp.Controllers
{
    public class AccountCreationController : Controller
    {
        private readonly ILogger<AccountCreationController> log;
        private UserDataHelper userDataHelper;

        public AccountCreationController(ILogger<AccountCreationController> logger)
        {
            log = logger;
            userDataHelper = new UserDataHelper();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string userName, string password)
        {
            try
            {
                if (userDataHelper.CheckIfUserExists(userName, password))
                {
                    log.LogError("User {0} already exists", userName);
                    return Json(new { success = false });
                }
                userDataHelper.CreateUser(userName: userName, password: password, accessLevel: 1);
            }
            catch(Exception e)
            {
                log.LogError("Error {0} creating user {0}", e, userName);
                return Json(new { success = false });
            }

            return Json(new { success = true });
        }
    }
}
