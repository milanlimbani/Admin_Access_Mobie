using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mobie.ViewModel;
using MobileShop.Models;
using sell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers
{
    
    public class UserHomeController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        private ICategory _categoryRepository;
        private IProduct _productRepository;
        private ISubCategory _subCategoryRepository;
        private Ilike _likeProductRepository;
        private IRegistration _UserRepository;
        private IUserHistory _userHistory;
        private IRegistration _registration;
        private  RoleManager<IdentityRole> roleManager;
        private  UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;


        public UserHomeController(SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager,IRegistration registration, ICategory categoryRepository, IWebHostEnvironment hostingEnvironment,IUserHistory userHistory, IProduct productRepository, ISubCategory subCategoryRepository,Ilike like,IRegistration user)
        {
            _categoryRepository = categoryRepository;
            _hostingEnvironment = hostingEnvironment;
            _productRepository = productRepository;
            _subCategoryRepository = subCategoryRepository;
            _likeProductRepository = like;
            _UserRepository = user;
            _userHistory = userHistory;
            _registration = registration;
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index(string message)
        {
            var userId = HttpContext.Session.GetString("UserId");

            ViewBag.message = message;
            ViewBag.UserId = userId;

            ViewData["PageTitle"] = "Product List";

            var result =
                from p in _productRepository.GetAllProduct()
                join c in _categoryRepository.GetAllCategory()
                on p.CatId equals c.Id
                join s in _subCategoryRepository.GetAllSubCategory() on p.SubId equals s.Id
                select new
                {
                    p.Id,
                    p.Name,
                    p.Qty,
                    p.Rate,
                    p.Profile,
                    p.IsActive,
                    p.CatId,
                    Category = c.Name,
                    p.Brand,
                    p.Generation,
                    p.Sims,
                    p.OS,
                    p.RAM,
                    p.ROM,
                    p.SubId,
                    SubCategory = s.Name,
                    p.Color
                };
            List<ProductViewModel> products = new List<ProductViewModel>();
            foreach (var each in result)
            {
                products.Add(new ProductViewModel()
                {
                    Category = each.Category,
                    CatId = each.CatId,
                    SubId = each.SubId,
                    Name = each.Name,
                    Id = each.Id,
                    Profile = each.Profile,
                    IsActive = each.IsActive,
                    Rate = each.Rate,
                    Qty = each.Qty,
                    Brand = each.Brand,
                    Generation = each.Generation,
                    Sims = each.Sims,
                    OS = each.OS,
                    RAM = each.RAM,
                    ROM = each.ROM,
                    Color = each.Color,
                    SubCategory = each.SubCategory
                });
            }
            return View(products);
        }

        public IActionResult searched(string Error)
        {
            ViewBag.ErrorMessage = Error;
            var userId = HttpContext.Session.GetString("UserId");
            ViewBag.UserId = userId;

            ViewData["PageTitle"] = "Product List";

            var result =
                from p in _productRepository.GetAllProduct()
                join c in _categoryRepository.GetAllCategory()
                on p.CatId equals c.Id
                join s in _subCategoryRepository.GetAllSubCategory() on p.SubId equals s.Id
                select new
                {
                    p.Id,
                    p.Name,
                    p.Qty,
                    p.Rate,
                    p.Profile,
                    p.IsActive,
                    p.CatId,
                    Category = c.Name,
                    p.Brand,
                    p.Generation,
                    p.Sims,
                    p.OS,
                    p.RAM,
                    p.ROM,
                    p.SubId,
                    SubCategory = s.Name,
                    p.Color
                };
            List<ProductViewModel> products = new List<ProductViewModel>();
            foreach (var each in result)
            {
                products.Add(new ProductViewModel()
                {
                    Category = each.Category,
                    CatId = each.CatId,
                    SubId = each.SubId,
                    Name = each.Name,
                    Id = each.Id,
                    Profile = each.Profile,
                    IsActive = each.IsActive,
                    Rate = each.Rate,
                    Qty = each.Qty,
                    Brand = each.Brand,
                    Generation = each.Generation,
                    Sims = each.Sims,
                    OS = each.OS,
                    RAM = each.RAM,
                    ROM = each.ROM,
                    Color = each.Color,
                    SubCategory = each.SubCategory
                });
            }
            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View(products);
        }
        public async Task<IActionResult> Details(int Pid)
        {
            var result =
                from p in _productRepository.GetAllProduct()
                join c in _categoryRepository.GetAllCategory()
                on p.CatId equals c.Id
                join s in _subCategoryRepository.GetAllSubCategory() on p.SubId equals s.Id
                where p.Id == Pid
                select new ProductViewModel
                {
                    Category = c.Name,
                    CatId = p.CatId,
                    SubId = p.SubId,
                    Name = p.Name,
                    Id = p.Id,
                    Profile = p.Profile,
                    IsActive = p.IsActive,
                    Rate = p.Rate,
                    Qty = p.Qty,
                    Brand = p.Brand,
                    Generation = p.Generation,
                    Sims = p.Sims,
                    OS = p.OS,
                    RAM = p.RAM,
                    ROM = p.ROM,
                    Color = p.Color,
                    SubCategory = s.Name
                };

            var product = result.FirstOrDefault();

            ViewData["PageTitle"] = product.Name;
            var user = await userManager.GetUserAsync(User);
            var userId = user?.Id;
            Product name = _productRepository.GetProductById(Pid);

            UserHistory hist = new UserHistory() { ProId = Pid, UserId = userId, ProductName = name.Name };

            _userHistory.AddHistory(hist);
            ViewBag.userdetails = _UserRepository.GetAllUser();
            return View("Details", product);
        }

        public IActionResult SearchByCategory(int Cid)
        {
            if(Cid==0)
            {
                ViewBag.ErrorMessage = $"Please select Category.";
                return RedirectToAction("searched", new { Error = ViewBag.ErrorMessage });
            }
            ViewBag.message = "Search By Category";
            var result =
                from p in _productRepository.GetAllProduct()
                join c in _categoryRepository.GetAllCategory()
                    on p.CatId equals c.Id
                join s in _subCategoryRepository.GetAllSubCategory()
                    on p.SubId equals s.Id
                where p.CatId == Cid
                select new ProductViewModel
                {
                    Category = c.Name,
                    CatId = p.CatId,
                    SubId = p.SubId,
                    Name = p.Name,
                    Id = p.Id,
                    Profile = p.Profile,
                    IsActive = p.IsActive,
                    Rate = p.Rate,
                    Qty = p.Qty,
                    Brand = p.Brand,
                    Generation = p.Generation,
                    Sims = p.Sims,
                    OS = p.OS,
                    RAM = p.RAM,
                    ROM = p.ROM,
                    Color = p.Color,
                    SubCategory = s.Name
                };

            var productList = result.AsEnumerable();

            if (productList == null || !productList.Any())
            {
                ViewBag.ErrorMessage = $"No products found for this category.";
                return RedirectToAction("searched", new { Error = ViewBag.ErrorMessage });
            }



            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View("searched",productList);
        }


        [HttpGet]
        public IActionResult SearchByRam(int ram)
        {
            if(ram==0)
            {
                ViewBag.ErrorMessage = $"Please select a Ram";
                return RedirectToAction("searched", new { Error = ViewBag.ErrorMessage });
            }
            ViewBag.message = "Search By Ram";
            var result =
                from p in _productRepository.GetAllProduct()
                join c in _categoryRepository.GetAllCategory()
                    on p.CatId equals c.Id
                join s in _subCategoryRepository.GetAllSubCategory()
                    on p.SubId equals s.Id
                where p.RAM == ram
                select new ProductViewModel
                {
                    Category = c.Name,
                    CatId = p.CatId,
                    SubId = p.SubId,
                    Name = p.Name,
                    Id = p.Id,
                    Profile = p.Profile,
                    IsActive = p.IsActive,
                    Rate = p.Rate,
                    Qty = p.Qty,
                    Brand = p.Brand,
                    Generation = p.Generation,
                    Sims = p.Sims,
                    OS = p.OS,
                    RAM = p.RAM,
                    ROM = p.ROM,
                    Color = p.Color,
                    SubCategory = s.Name
                };

            var productList = result.AsEnumerable();

            if (productList == null || !productList.Any())
            {
                ViewBag.ErrorMessage = $"No products found for Ram {ram} GB.";
                return RedirectToAction("searched",new { Error = ViewBag.ErrorMessage });
            }




            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View("searched", productList);
        }

        [HttpGet]
        public IActionResult SearchByRom(int rom)
        {
            if (rom == 0)
            {
                ViewBag.ErrorMessage = $"Please select a Rom";
                return RedirectToAction("searched", new { Error = ViewBag.ErrorMessage });
            }
            ViewBag.message = "Search By Rom";
            var result =
                from p in _productRepository.GetAllProduct()
                join c in _categoryRepository.GetAllCategory()
                    on p.CatId equals c.Id
                join s in _subCategoryRepository.GetAllSubCategory()
                    on p.SubId equals s.Id
                where p.ROM == rom
                select new ProductViewModel
                {
                    Category = c.Name,
                    CatId = p.CatId,
                    SubId = p.SubId,
                    Name = p.Name,
                    Id = p.Id,
                    Profile = p.Profile,
                    IsActive = p.IsActive,
                    Rate = p.Rate,
                    Qty = p.Qty,
                    Brand = p.Brand,
                    Generation = p.Generation,
                    Sims = p.Sims,
                    OS = p.OS,
                    RAM = p.RAM,
                    ROM = p.ROM,
                    Color = p.Color,
                    SubCategory = s.Name
                };

            var productList = result.AsEnumerable();

            if (productList == null || !productList.Any())
            {
                ViewBag.ErrorMessage = $"No products found for Rom {rom} GB.";
                return RedirectToAction("searched", new { Error = ViewBag.ErrorMessage });
            }



            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View("searched", productList);
        }

        [HttpGet]
        public IActionResult SearchByGen(string gen)
        {
            if (gen == null)
            {
                ViewBag.ErrorMessage = $"Please select a Network";
                return RedirectToAction("searched", new { Error = ViewBag.ErrorMessage });
            }
            ViewBag.message = "Search By Network";
            var result =
                from p in _productRepository.GetAllProduct()
                join c in _categoryRepository.GetAllCategory()
                    on p.CatId equals c.Id
                join s in _subCategoryRepository.GetAllSubCategory()
                    on p.SubId equals s.Id
                where p.Generation.ToLower() == gen.ToLower()
                select new ProductViewModel
                {
                    Category = c.Name,
                    CatId = p.CatId,
                    SubId = p.SubId,
                    Name = p.Name,
                    Id = p.Id,
                    Profile = p.Profile,
                    IsActive = p.IsActive,
                    Rate = p.Rate,
                    Qty = p.Qty,
                    Brand = p.Brand,
                    Generation = p.Generation,
                    Sims = p.Sims,
                    OS = p.OS,
                    RAM = p.RAM,
                    ROM = p.ROM,
                    Color = p.Color,
                    SubCategory = s.Name
                };

            var productList = result.AsEnumerable();

            if (productList == null || !productList.Any())
            {
                ViewBag.ErrorMessage = $"No products found for {gen}.";
                return RedirectToAction("searched", new { Error = ViewBag.ErrorMessage });
            }
            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View("searched", productList);
        }

        [HttpGet]
        public IActionResult SearchByComp(string brand)
        {
            if (brand != null)
            {
                ViewBag.message = "Search By CompanyName";
                var result =
               from p in _productRepository.GetAllProduct()
               join c in _categoryRepository.GetAllCategory()
                   on p.CatId equals c.Id
               join s in _subCategoryRepository.GetAllSubCategory()
                   on p.SubId equals s.Id
               where p.Brand.ToLower().Trim() == brand.ToLower().Trim()
               select new ProductViewModel
               {
                   Category = c.Name,
                   CatId = p.CatId,
                   SubId = p.SubId,
                   Name = p.Name,
                   Id = p.Id,
                   Profile = p.Profile,
                   IsActive = p.IsActive,
                   Rate = p.Rate,
                   Qty = p.Qty,
                   Brand = p.Brand,
                   Generation = p.Generation,
                   Sims = p.Sims,
                   OS = p.OS,
                   RAM = p.RAM,
                   ROM = p.ROM,
                   Color = p.Color,
                   SubCategory = s.Name
               };

                var productList = result.AsEnumerable();

                if (productList == null || !productList.Any())
                {
                    ViewBag.ErrorMessage = $"No products found for Company {brand}.";
                    return RedirectToAction("searched", new { Error = ViewBag.ErrorMessage });
                }
                ViewBag.Category = _categoryRepository.GetAllCategory();
                return View("searched", productList);
            }

            else
            {

                ViewBag.ErrorMessage = $"Please Select a Brand Name";
                return RedirectToAction("searched", new { Error = ViewBag.ErrorMessage });
            }

        }
      
    }
}

