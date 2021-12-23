using Pizza.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public class OrderDetail
    {
        public int id { set; get; }

        public int orderID { get; set; }

        public int ProductID { get; set; }

        public decimal price { get; set; }

        public virtual Products products { get; set; }

        public virtual UserOrder usrorder { get; set; }
    }
}
