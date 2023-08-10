using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Models;
using sell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers
{
    [Authorize(Roles = "User,Admin")]
    
    public class LogedinController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        private ICategory _categoryRepository;
        private IProduct _productRepository;
        private ISubCategory _subCategoryRepository;
        private IRegistration _registration;
        private Ilike _like;
        private IUserHistory _userHistory;
        private RoleManager<IdentityRole> roleManager;
        private UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public LogedinController(SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager,ICategory categoryRepository, IWebHostEnvironment hostingEnvironment, IProduct productRepository, ISubCategory subCategoryRepository, IRegistration registration, Ilike like, IUserHistory userHistory)
        {
            _categoryRepository = categoryRepository;
            _hostingEnvironment = hostingEnvironment;
            _productRepository = productRepository;
            _subCategoryRepository = subCategoryRepository;
            _registration = registration;
            _like = like;
            _userHistory = userHistory;
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult AddLike(int Pid, string Uid, string Pname)
        {
            Like likes = new Like() { ProId = Pid, UserId = Uid, ProductName = Pname };

            bool result = _like.AddLike(likes);

            if (result)
            {
                ViewBag.message = "Product Liked Successfully.";
            }
            else
            {
                ViewBag.message = "Error: Already Like Product.";
            }
            ViewBag.userId = Uid;
            return RedirectToAction("Index", "UserHome",new { message= ViewBag.message });
        }

        public async Task<IActionResult> GetLikesByUserId(string message)
        {
            ViewBag.message = message;

            var user = await userManager.GetUserAsync(User);
            var userId = user?.Id;
           
            ViewBag.UserId = user.Id;
            
            var likes = _like.GetLikesByUserId(userId);

            return View("Likes", likes);
        }


        public async Task<IActionResult> RemoveLikes(int Lid)
        {
            var user = await userManager.GetUserAsync(User);
            var userId = user?.Id;

            ViewBag.UserId = user.Id;
            
            Like liked = _like.GetLikeById(Lid);
            _like.RemoveLike(liked);
            ViewBag.message = "Liked Product Removed Sucessfully.";
            return RedirectToAction("GetLikesByUserId", new { message = ViewBag.message });
        }

        public async Task<IActionResult> GetUserHistoryByUserId()
        {
            ViewData["ErrorMessage"] = TempData["ErrorMessage"];
            ViewData["SuccessMessage"] = TempData["SuccessMessage"];
            var user = await userManager.GetUserAsync(User);
            var userId = user?.Id;


            var history = _userHistory.GetHistoryByUserId(userId);

            return View("history", history);
        }

    }
}
