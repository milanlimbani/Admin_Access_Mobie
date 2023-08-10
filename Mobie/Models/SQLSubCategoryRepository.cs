using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class SQLSubCategoryRepository:ISubCategory
    {
        private AppDbContext _subcategory;
        public SQLSubCategoryRepository(AppDbContext context)
        {
            _subcategory = context;
        }
        public bool AddSubCategory(SubCategory subcat)
        {

            if (CheckInsertUnique( subcat.CatId, subcat.Name))
            {
                
                _subcategory.Add(subcat);
                _subcategory.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckInsertUnique( int Cid,string name)
        {
            SubCategory isDuplicate = _subcategory.SubCategories.FirstOrDefault(each => each.CatId == Cid && name.ToLower() == each.Name.ToLower());
            return isDuplicate == null ? true : false;
        }
        public IEnumerable<SubCategory> GetAllSubCategory()
        {
            return _subcategory.SubCategories;
        }

     

        public SubCategory GetSubCategoryId(int id)
        {
            return _subcategory.SubCategories.SingleOrDefault(each => each.Id == id);
        }
        public bool RemoveCategory(SubCategory cat)
        {
            SubCategory isDuplicate = _subcategory.SubCategories.FirstOrDefault(each => each.Id == cat.Id);
            if (isDuplicate != null)
            {
                _subcategory.Remove(cat);
                _subcategory.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateSubCategory(SubCategory s)
        {
            if (CheckUpdateUnique(s.Id,s.CatId,s.Name))
            {
                _subcategory.SubCategories.Update(s);
                _subcategory.SaveChanges();
                return true;
            }
            return false;
        }

        public bool CheckUpdateUnique(int Sid, int Cid, string name)
        {
            SubCategory sub = _subcategory.SubCategories.FirstOrDefault(each => each.Name.ToLower() == name.ToLower());
            if (sub == null)
                return true;
            sub = _subcategory.SubCategories.FirstOrDefault(each => each.Name.ToLower() == name.ToLower() && each.CatId == Cid && each.Id == Sid);
            if (sub != null)
                return true;
            bool flag = false;

            foreach (SubCategory s in _subcategory.SubCategories)
            {
                if (s.Name.ToLower() == name.ToLower() && s.CatId != Cid)
                {
                    flag = true;
                }
                else if (s.Name.ToLower() == name.ToLower() && s.CatId == Cid)
                {
                    return false;
                }
            }
            return flag;
        }

        public IEnumerable<SubCategory> GetSubCategoriesByCategoryId(int Cid)
        {
            return _subcategory.SubCategories.Where(s => s.CatId == Cid).ToList();
        }


    }
}
