using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using MobileShop.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace MobileShop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        private ICategory _categoryRepository;
        private ISubCategory _subCategory;
        public CategoryController(ICategory categoryRepository,ISubCategory subCategory, IWebHostEnvironment hostingEnvironment)
        {
            _categoryRepository = categoryRepository;
            _hostingEnvironment = hostingEnvironment;
            _subCategory = subCategory;
        }
        public IActionResult Index(string message)
        {
            ViewBag.message = message;
            return View(_categoryRepository.GetAllCategory());
        }

        public IActionResult AddCategory(string name)
        {
            Category category = new Category() { Name = name };
            return Json(_categoryRepository.AddCategory(category));
        }
        public IActionResult RemoveCategory(int Cid)
        {
           
            bool isCategoryPresentInSubCategory = _subCategory.GetAllSubCategory().Any(sc => sc.CatId == Cid);

            if (isCategoryPresentInSubCategory)
            {
                ViewBag.message = "Cannot delete category as it is present in subcategory.";
                return RedirectToAction("Index", new { message = ViewBag.message });
            }
            else
            {
                Category category = _categoryRepository.GetCategoryId(Cid);
                _categoryRepository.RemoveCategory(category);
                ViewBag.message = " Category Deleted Sucessfully.";
                return RedirectToAction("Index", new { message = ViewBag.message });
            }
            
        }


        public IActionResult Edit(int Cid, string name)
        {
            var category = _categoryRepository.GetCategoryId(Cid);

            category.Name = name;
            _categoryRepository.UpdateCategory(category);

            return Json(new { success = true });
        }




    }
}
