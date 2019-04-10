using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegisterAndLogin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace RegisterAndLogin.Controllers
{
    public class HomeController : Controller
    {
        private UserContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(UserContext context)
        {
            dbContext = context;
        }
        
        
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Register")]
        [HttpPost]
        public IActionResult Register(User newUser)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            else
            {
                if (dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Users.Add(newUser);
                    dbContext.SaveChanges();
                    Loginuser.SetLogin(HttpContext, newUser.UserId);
                    return View("Success");
                }
            }
        }

        [Route("Login")]
        [HttpPost]
        public IActionResult Login(Loginuser newLoginUser)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            else
            {
                User needLogin = dbContext.Users.FirstOrDefault(u => u.Email == newLoginUser.LogEmail);
                if (needLogin == null)
                {
                    ModelState.AddModelError("LogEmail", "This email didn't exist.Please rigester first!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                var verifyPass = Hasher.VerifyHashedPassword(needLogin, needLogin.Password, newLoginUser.LogPassword);
                if (verifyPass == 0)
                {
                    ModelState.AddModelError("LogPassword", "Password is wrong!");
                    return View("Index");
                }
                else
                {
                    Loginuser.SetLogin(HttpContext , needLogin.UserId);
                    return View("Success");
                }
            }
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

    }
}
