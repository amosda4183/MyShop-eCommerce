using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        //Default constructor
        public DataContext()
            : base("DefaultConnection")
        {

        }  

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }

        //SQL setup commands
        //Enable-Migrations
        //Add-Migration (generic name) Initial - generarates commands to create tables in the database
        //Update-Database - creates database tables generated from migration
        
    }
}
