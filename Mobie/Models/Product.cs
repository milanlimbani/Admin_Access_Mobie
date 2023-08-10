using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class Product
    {
        public int Id { get; set; }



        [Required(ErrorMessage = "Product Name should not empty")]
        [MaxLength(50, ErrorMessage = "product name should  not more than 50")]
        public string Name { get; set; }



        [Range(1, Int32.MaxValue, ErrorMessage = "Qty should be more than Zero")]
        public int Qty { get; set; }



        [Range(1, Int32.MaxValue, ErrorMessage = "Rate should be more than Zero")]
        public int Rate { get; set; }
        public string Profile { get; set; }



        public bool IsActive { get; set; } = true;
        public int CatId { get; set; }



        public int SubId { get; set; }




        [Required(ErrorMessage = "Brand Name should not empty")]
        [MaxLength(100, ErrorMessage = "Brand name should  not more than 100")]
        public string Brand { get; set; }


        [Required(ErrorMessage = "Generation should not empty")]
        public string Generation { get; set; }


        [Required(ErrorMessage = "Color should not empty")]
        public string Color { get; set; }



        [Range(1, Int32.MaxValue, ErrorMessage = "Sim should be more than Zero")]
        public int Sims { get; set; }


        [Required(ErrorMessage = "OS should not empty")]
        public string OS { get; set; }



        [Range(1, Int32.MaxValue, ErrorMessage = "RAM should be more than Zero")]
        public int RAM { get; set; }



        [Range(1, Int32.MaxValue, ErrorMessage = "ROM should be more than Zero")]
        public int ROM { get; set; }
    }
}
