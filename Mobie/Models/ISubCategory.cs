using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public interface ISubCategory
    {

        SubCategory GetSubCategoryId(int id);
        IEnumerable<SubCategory> GetAllSubCategory();
     
        bool AddSubCategory(SubCategory subcat);


        bool RemoveCategory(SubCategory subcat);
        bool UpdateSubCategory(SubCategory subcat);
        IEnumerable<SubCategory> GetSubCategoriesByCategoryId(int Sid);
        public bool CheckUpdateUnique(int Sid, int Cid, string name);

    }
}
