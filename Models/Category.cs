using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Toy_Story_Directory.Models
{
    public class Category
    {
        public int CategoryId { get; set; } // Primary Key
        [Required]
        public string Name { get; set; }

        public List<Product>Products { get; set; }
        

    }
}
