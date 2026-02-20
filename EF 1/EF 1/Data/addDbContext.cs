using EF_1.Data;
using EF_1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace EF_1.Data
{
    public class addDbContext : DbContext
    {
        public DbSet<student> students { get; set; }

        public DbSet<Course> courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-FFPI4CQG\\SQLEXPRESS01;Database=EFCoreDb;Trusted_Connection=True;TrustServerCertificate=True;");

        }



        //-------------------------------------------------------------- Seeding Entity ------------------------------------------------------//
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<trainer>().HasData(
                new trainer { Id = 1, Name = "Mewada", ExperienceYears = 6 },
                new trainer { Id = 2, Name = "Raj", ExperienceYears = 4 }
                );
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Title = ".NET Core", Fees = 25600, DurationinMonths = 6},
                new Course { Id = 2, Title = "LINQ", Fees = 15500, DurationinMonths = 3}
                );
            modelBuilder.Entity<student>().HasData(
                new student { Id = 1, Name = "Het", Email = "het@gmail.com", CreatedDate = new DateTime(2026, 1, 20) },
                new student { Id = 2, Name = "Jeet", Email = "jeet@gmail.com", CreatedDate = new DateTime(2026, 2, 11) }
                
               );

        }
    }
}
