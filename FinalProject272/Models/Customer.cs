using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject272.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string ContactNumber { get; set; }
        public virtual ICollection<UserRoles> UserRoless { get; set; }
        public virtual ICollection<ContactViewModel> ContactViewModels { get; set; }
    }
}