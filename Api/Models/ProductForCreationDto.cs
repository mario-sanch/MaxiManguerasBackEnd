﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class ProductForCreationDto
    {
        #region Properties
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public double Price { get; set; }
        [MaxLength(100)]
        public string ImageUrl { get; set; }
        #endregion
    }
}
