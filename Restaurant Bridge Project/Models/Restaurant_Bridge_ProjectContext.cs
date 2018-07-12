using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Restaurant_Bridge_Project.Models
{
    public class Restaurant_Bridge_ProjectContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Restaurant_Bridge_ProjectContext() : base("name=Restaurant_Bridge_ProjectContext")
        {
        }

        public System.Data.Entity.DbSet<Restaurant_Bridge_Project.Models.Customers> Customers { get; set; }

        public System.Data.Entity.DbSet<Restaurant_Bridge_Project.Models.Employees> Employees { get; set; }

        public System.Data.Entity.DbSet<Restaurant_Bridge_Project.Models.Menu> Menus { get; set; }

        public System.Data.Entity.DbSet<Restaurant_Bridge_Project.Models.Address> Addresses { get; set; }
    }
}
