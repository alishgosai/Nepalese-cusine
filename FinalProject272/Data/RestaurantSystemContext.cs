using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalProject272.Data
{
    public class RestaurantSystemContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public RestaurantSystemContext() : base("name=RestaurantSystemContext")
        {
        }

        public System.Data.Entity.DbSet<FinalProject272.Models.UserRoles> UserRoles { get; set; }

        public System.Data.Entity.DbSet<FinalProject272.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<FinalProject272.Models.MenuItem> MenuItems { get; set; }

        public System.Data.Entity.DbSet<FinalProject272.Models.Staff> Staffs { get; set; }

        public System.Data.Entity.DbSet<FinalProject272.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<FinalProject272.Models.ContactViewModel> ContactViewModels { get; set; }

        public System.Data.Entity.DbSet<FinalProject272.Models.Booking> Bookings { get; set; }
    }
}
