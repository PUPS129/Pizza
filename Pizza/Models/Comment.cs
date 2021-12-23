using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int UserID { get; set; }
        public string UsrComment { get; set; }
        public virtual IdentityUser IdentityUser { get; set; }

    }
}
