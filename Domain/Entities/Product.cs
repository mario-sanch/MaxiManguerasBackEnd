using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Product
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        #endregion
    }
}
