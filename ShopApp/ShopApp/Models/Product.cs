using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [Range(0, 99999)]
        public decimal Price { get; set; }
        [MaxLength(200)]
        public string ImagePath { get; set; }
        public string Category { get; set; }
        [Range(0, 99999)]
        public decimal? DiscountPrice { get; set; }


        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
