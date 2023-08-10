using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using MobileShop.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace MobileShop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SubCategoryController : Controller
    {

        private ICategory _category;
        private ISubCategory _subCategory;
        private IProduct _product;

        public SubCategoryController(ISubCategory SubCategoryRepository,ICategory category,IProduct product)
        {
            _category = category;
            _subCategory = SubCategoryRepository;
            _product = product;
        }



        public IActionResult Index(string message)
        {
            ViewBag.message = message;
            ViewBag.Category = _category.GetAllCategory();
            return View("Index", _subCategory.GetAllSubCategory());
        }
        public IActionResult AddSubCategory(int Cid,string name)
        {
            SubCategory Subcategory = new SubCategory() { CatId = Cid, Name = name };
            return Json(_subCategory.AddSubCategory(Subcategory));
        }

        public IActionResult FindId(int Sid)
        {
            return Json(_subCategory.GetSubCategoryId(Sid));
        }

        public IActionResult RemoveSubCategory(int Sid)
        {

            bool isProductPresentInSubCategory = _product.GetAllProduct().Any(sc => sc.SubId == Sid);

            if (isProductPresentInSubCategory)
            {
                ViewBag.message = "Cannot delete Subcategory as its Product Exists.";
                return RedirectToAction("Index", new { message = ViewBag.message });
            }

            SubCategory subcategory = _subCategory.GetSubCategoryId(Sid);
            _subCategory.RemoveCategory(subcategory);
            ViewBag.message = "SubCategory Deleted Sucessfully.";
            return RedirectToAction("Index", new { message = ViewBag.message });
        }

        public IActionResult CheckUpdateUnique(int Sid, int Cid, string name)
        {
            bool value = _subCategory.CheckUpdateUnique(Sid, Cid, name);
            return Json(value);
        }

        public IActionResult Edit(int Sid, int Cid, string name)
        {
            var subcategory = _subCategory.GetSubCategoryId(Sid);

            subcategory.Name = name;
            subcategory.CatId = Cid;

            if (_subCategory.UpdateSubCategory(subcategory))
            {
                return Json(new { success = true });
            }
            else
            {
                return BadRequest("Unable to update subcategory.");
            }
        }

        public IActionResult GetSubCategoriesByCategoryId(int Cid)
        {
            var subCategories = _subCategory.GetSubCategoriesByCategoryId(Cid);

            return View("SubCatview", subCategories);
        }
    }

}

