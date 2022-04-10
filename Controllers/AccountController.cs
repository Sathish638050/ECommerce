using Ecommerce.EazyCartModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserAccount u)
        {
            using(var db = new EcommerceContext())
            {
                db.UserAccounts.Add(u);
                db.SaveChanges();
            }
            return RedirectToAction("Login", "Account");
            
        }
    }
}
