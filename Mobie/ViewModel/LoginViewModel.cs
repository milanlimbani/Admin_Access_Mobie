﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mobie.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Display(Name = "Rember Me")]
        public Boolean IsRember { get; set; }
    }
}
