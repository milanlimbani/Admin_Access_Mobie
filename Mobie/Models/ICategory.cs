using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public interface ICategory
    {
        Category GetCategoryId(int Cid);
        IEnumerable<Category> GetAllCategory();
        bool AddCategory(Category cat);
   
       
        Category GetCategoryByName(string name);
        bool RemoveCategory(Category category);
        void UpdateCategory(Category category);
    
    }
}
