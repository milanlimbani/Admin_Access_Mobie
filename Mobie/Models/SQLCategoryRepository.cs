﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class SQLCategoryRepository : ICategory
    {

        private AppDbContext _category;
        public SQLCategoryRepository(AppDbContext context)
        {
            _category = context;
        }
        public bool AddCategory(Category cat)
        {
            Category isDuplicate = _category.Categories.FirstOrDefault(each => each.Name.ToLower() == cat.Name.ToLower());
            if (isDuplicate == null)
            {
                _category.Add(cat);
                _category.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public IEnumerable<Category> GetAllCategory()
        {
            return _category.Categories;
        }

        public Category GetCategoryId(int Cid)
        {
            return _category.Categories.SingleOrDefault(each => each.Id == Cid);
        }


        public Category GetCategoryByName(string name)
        {
            return _category.Categories.FirstOrDefault(category => category.Name == name);
        }

        public bool RemoveCategory(Category cat)
        {
            Category isDuplicate = _category.Categories.FirstOrDefault(each => each.Id == cat.Id);
            if (isDuplicate != null)
            {
                _category.Remove(cat);
                _category.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckUpdateUnique(string name, int catId)
        {
            bool isUnique = !_category.Categories.Any(c => c.Name.ToLower() == name.ToLower() && c.Id != catId);
            return isUnique;
        }

        public void UpdateCategory(Category category)
        {
            _category.Entry(category).State = EntityState.Modified;
            _category.SaveChanges();
        }



    }
}
