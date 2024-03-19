﻿using EasyToBuy.Data.DBClasses;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EasyToBuy.Data
{
    public class ApplicationDbContext : DbContext   
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base (options)
        {
                
        }

        public DbSet<User> UserMaster { get; set; }
        public DbSet<Country> tblCountry { get; set; }
        public DbSet<State> tblState { get; set; }
        public DbSet<City> tblCity { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-E86JM10\\SQLEXPRESS;Database=EasyToBuyDb;Trusted_Connection=True;TrustServerCertificate=True;Trusted_Connection=True;");
        }

    }
}
