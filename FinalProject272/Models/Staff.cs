using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject272.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public virtual MenuItem MenuItems { get; set; }
        public virtual ICollection<UserRoles> UserRoless { get; set; }
    }
}