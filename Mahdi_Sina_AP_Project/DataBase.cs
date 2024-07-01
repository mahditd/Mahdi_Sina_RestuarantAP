using Microsoft.EntityFrameworkCore;
using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahdi_Sina_AP_Project
{
    internal class DataBase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source =.\DATABASE.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>().HasNoKey();
            modelBuilder.Entity<Complaint>().HasNoKey();
            modelBuilder.Entity<Reserve>().HasNoKey();
            modelBuilder.Entity<Food>().HasNoKey();

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Restaurant> Restaurants { get; set;}
        public DbSet<Admin> admins { get; set; }



    }
}
