using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class SubCategory
    {
        public int CatId { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage ="Subcategory Name should not empty")]
        [MaxLength(100,ErrorMessage ="SubCategory Name should not more than 100")]
        
        public string Name { get; set; }
    }
}
