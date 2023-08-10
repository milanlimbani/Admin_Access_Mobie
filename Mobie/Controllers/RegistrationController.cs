using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MobileShop.Controllers
{
    public class RegistrationController : Controller

    {
        //private IWebHostEnvironment _hostingEnvironment;
        //private IRegistration _registration;
        //public RegistrationController(ICategory categoryRepository, IWebHostEnvironment hostingEnvironment, IProduct productRepository, ISubCategory subCategoryRepository, IRegistration registration)
        //{
           
        //    _hostingEnvironment = hostingEnvironment;
           
        //    _registration = registration;
        //}

        //public IActionResult loggedinuser(string message,int userId)
        //{
        //    ViewBag.UserId = userId;
        //    ViewBag.username = message;
            
        //    return RedirectToAction("Index", "UserHome", new { message = ViewBag.username,userId=ViewBag.UserId });
            
        //}
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //public IActionResult Login()
        //{
            
        //    ViewData["ErrorMessage"] = TempData["ErrorMessage"];
        //     ViewBag.Layout = "~/Views/Shared/_null.cshtml";
        //    return View("Login");
        //}

        //public IActionResult AddUser(string name, string email, string password)
        //{
        //    Registration User = new Registration() { Username = name, Email = email, Password = password };
        //    bool success = _registration.AddUser(User);
        //    if (success)
        //    {
        //        return Json(new { success = true });
        //    }
        //    else
        //    {
        //        return Json(new { success = false, errorMessage = "User with Same Email already Exists." });
        //    }
        //}

        //public IActionResult FindUser(string email, string password)
        //{
        //    Registration user = new Registration() { Email = email, Password = password };
        //    if (email == "Admin@gmail.com" && password == "123")
        //    {
               
        //        ViewBag.username = email;
               
        //        return RedirectToAction("Index", "Home", new { message = ViewBag.username });
        //    }
        //    bool isVerified = _registration.VerifyUser(user);
        //     if (!isVerified)
        //    {
                
        //        ViewBag.Username = email;
        //        TempData["ErrorMessage"] = "User Not Found.";
        //        return RedirectToAction("Login");
        //    }
        //    else
        //    {
        //        Registration verifiedUser = _registration.GetUserByEmail(email);

        //        // Get the user ID of the verified user
        //        int userId = verifiedUser.Id;
        //        Registration Data = _registration.CheckUser(user);
        //        CookieOptions options = new CookieOptions();
        //        options.Expires = DateTime.Now.AddMinutes(30);
        //        Response.Cookies.Append("UserId", userId.ToString(), options);
        //        ViewBag.userId = Data.Id;
        //        ViewBag.Username = email;
        //        return RedirectToAction("loggedinuser", "Registration", new { message = ViewBag.username, userid = ViewBag.userId });
        //    }

        //}

     


        //public IActionResult Logout()
        //{
            
        //    Response.Cookies.Delete("UserId");

        //    return RedirectToAction("Index","UserHome");
        //}



    }
}

