using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toy_Story_Directory.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; } // Primary Key
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public Decimal Price { get; set; }
        
        public Order Order { get; set; }

        public Product Product { get; set; }

    }
}
