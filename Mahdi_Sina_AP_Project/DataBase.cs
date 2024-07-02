using Microsoft.EntityFrameworkCore;
using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Mahdi_Sina_AP_Project
{
    public class DataBase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source =D:\elmos\AP\project\new project\Mahdi_Sina_RestuarantAP\Mahdi_Sina_AP_Project\DATABASE.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(c => c.ID);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Customer> Customers { get; set; }



    }
}
