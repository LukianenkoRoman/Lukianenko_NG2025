using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication3.Models;
using WebApplication3.Controllers;
using _2025Epic1Task1.Controllers;

namespace WebApplication3.Controllers
{
    public class LoginController : Controller
    {
        private static List<UserModel> users = new List<UserModel>
        {
            new UserModel { Email = "randomuser@gmail.com", Password = "password"},
            new UserModel { Email = "randomadmin@gmail.com", Password = "admin"}
        };

        public IActionResult Verify()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Verify(string email, string password)
        {
            var user = users.Find(u => u.Email == email && u.Password == password);

            if (string.IsNullOrEmpty(email))
            {
                ViewBag.ErrorMessage = "Email field is empty.";
                return View();
            }
            if (string.IsNullOrEmpty(password))
            {
                ViewBag.ErrorMessage = "Password field is empty.";
                return View();
            }

            if (user == null)
            {
                ViewBag.ErrorMessage = "Incorrect data";
                return View();
            }

            LoginStatus.IsAuthenticated = true; 
            return RedirectToAction("Index", "Home");
        }
    }
}