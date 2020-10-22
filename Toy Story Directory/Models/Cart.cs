using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toy_Story_Directory.Models
{
    public class Cart
    {
        public int CartId { get; set; } // Primary Key
        public int ProductId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CustomerId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}
