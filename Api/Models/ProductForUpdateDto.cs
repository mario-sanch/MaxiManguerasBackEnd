﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class ProductForUpdateDto
    {
        #region Properties
        public string Name { get; set; }
        public string Description { get; set; } 
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        #endregion
    }
}
