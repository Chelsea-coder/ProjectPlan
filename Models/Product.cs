using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Toy_Story_Directory.Models
{
    public class Product
    {
        public int ProductId { get; set; } // Primary Key
        [Required]
        public String Name { get; set; }
        [Required]
        public String Description { get; set; }
        public string Photo { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(0.01, 99999)]
        public Decimal Price { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
