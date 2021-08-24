using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2E1NETCore_MVC_Hello.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {
            if (Email == "luis@qboinstitute.com" && Password == "123456")
            {
                return RedirectToAction("Index", "Home", new { area = "Marketing" });
            }
            return RedirectToAction("Login");
        }

    }
}
