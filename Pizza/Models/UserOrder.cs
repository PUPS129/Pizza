using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models.Entities
{
    public class UserOrder
    {
        public UserOrder()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }
        [Key]
        [Required]
        public int IdUserOrder { get; set; }
        [Required]
        public string idClient { get; set; }
      
        [Required]
        public string EmailClient { get; set; }
       
       
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true)]
        
        public DateTime PointDate { get; set; }

        public int statusId { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }

        [NotMapped]
        public string CorrectDateTime
        {
            get
            {
                return PointDate.ToShortDateString();
            }
        }
     




    }
}
