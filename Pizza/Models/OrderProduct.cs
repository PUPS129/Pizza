using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models.Entities
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int orderID { get; set; }
        public virtual UserOrder Order { get; set; }
        public int productID { get; set; }
        public virtual Products Product { get; set; }
        public int Quantity { get; set; }
    }
}
