using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestLogowanie.Controllers
{
    
    public class TestController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(UserProfile objUserLogin)
        {
            ZalogowanieEntities dane = new ZalogowanieEntities();

            foreach (var a in dane.UserProfile)
            {
                if (objUserLogin.UserName == a.UserName && objUserLogin.Password == a.Password)
                { 
                    return View("WelcomePage", objUserLogin);
                }
            }
           
           
                // objUserLogin.Message = "Invalid UserName/Password";
                return View(objUserLogin);
            
            
        }
    }
}