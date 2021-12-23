using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models.Entities
{
    public class Products
    {
        public Products()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public float Price { get; set; }

        
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
