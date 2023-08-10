using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MobileShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;



namespace MobileShop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        private ICategory _categoryRepository;
        private IProduct _productRepository;
        private ISubCategory _subCategoryRepository;
        public HomeController(ICategory categoryRepository, IWebHostEnvironment hostingEnvironment, IProduct productRepository, ISubCategory subCategoryRepository)
        {
            _categoryRepository = categoryRepository;
            _hostingEnvironment = hostingEnvironment;
            _productRepository = productRepository;
            _subCategoryRepository = subCategoryRepository;
        }

        public IActionResult Index(string message)
        {
            ViewBag.username = message;
            ViewData["SuccessMessage"] = TempData["SuccessMessage"];
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
        public IActionResult Delete(int Id)
        {
            Product prod = _productRepository.GetProductById(Id);
            _productRepository.RemoveProduct(prod);
            TempData["SuccessMessage"] = "Product Deleted Sucessfully.";
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            Product p = _productRepository.GetProductById(id);
            ProductViewModel productViewModel = new ProductViewModel()
            {
              
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
                
            };
            ViewBag.Category = _categoryRepository.GetAllCategory();
            ViewBag.SubCategory = _subCategoryRepository.GetAllSubCategory();
            return View("AddProduct", productViewModel);
        }
        public IActionResult Save(ProductViewModel p)
        {
         
                String uniqueFileName = string.Empty;
                if (p.Image != null)
                {
                    String uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + p.Image.FileName;
                    String uploadFilePath = Path.Combine(uploadFolder, uniqueFileName);
                    p.Image.CopyTo(new FileStream(uploadFilePath, FileMode.Create));
                    p.Profile = uniqueFileName;
                }
                if (p.Id > 0)
                {
                    if (!_productRepository.UpdateProduct(p))
                    {
                        ViewBag.Category = _categoryRepository.GetAllCategory();
                        ViewBag.SubCategory = _subCategoryRepository.GetAllSubCategory();
                    return View("AddProduct", p);
                    }
                }
                else
                {
                    if (!_productRepository.AddProduct(p))
                    {
                        ViewBag.Category = _categoryRepository.GetAllCategory();
                        ViewBag.SubCategory = _subCategoryRepository.GetAllSubCategory();
                    return View("AddProduct", p);
                    }

                }
                return RedirectToAction("Index");
      
        }
        public IActionResult CheckUpdateUnique(String name, int catId, int prodId)
        {
            bool value = _productRepository.CheckUpdateUnique(name, catId, prodId);
            return Json(value);
        }
        public IActionResult CheckInsertUnique(String name, int catId)
        {
            bool value = _productRepository.CheckInsertUnique(name, catId);
            return Json(value);
        }
        public IActionResult AddProduct()
        {
            ViewBag.Category = _categoryRepository.GetAllCategory();
            ViewBag.SubCategory = _subCategoryRepository.GetAllSubCategory();
            return View(new ProductViewModel());
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetProductBySubCatId(int Sid)
        {
            var products = _productRepository.GetProductBySubCatId(Sid);

            return View("Productview", products);
        }
    }
}

