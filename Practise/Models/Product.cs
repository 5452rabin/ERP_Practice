﻿using System.ComponentModel.DataAnnotations;

namespace Practise.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
