using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Products> products { get; set; }
    }
}
