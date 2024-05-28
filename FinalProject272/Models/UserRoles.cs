using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject272.Models
{
    public class UserRoles
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public virtual User Users { get; set; }
        public virtual Customer Customers { get; set; }
    }
}