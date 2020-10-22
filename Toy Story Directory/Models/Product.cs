using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toy_Story_Directory.Models
{
    public class Product
    {
        public int ProductId { get; set; } // Primary Key

        public String Name { get; set; }
        public String Description { get; set; }
        public int Photo { get; set; }
        public Decimal Price { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
