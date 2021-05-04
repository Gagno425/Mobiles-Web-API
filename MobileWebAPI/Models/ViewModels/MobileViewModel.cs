﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileWebAPI.Models.ViewModels
{
    public class MobileViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int ManufacturerId { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
