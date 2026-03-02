using EF_1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_1
{
    public class AppDbContext
    {
        using Microsoft.EntityFrameworkCore;

       public class AppDbContext : DbContext
    {
        // Step 1: Define Tables
        public DbSet<student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<trainer> Trainers { get; set; }
        public DbSet<batch> Batches { get; set; }

        // Step 2: Configure Database Connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost\\SQLEXPRESS;Database=TrainingDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        // Step 3: Configure Relationships + Seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Many-to-Many: Student ↔ Course
            modelBuilder.Entity<student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students);

            // Seed Trainers
            modelBuilder.Entity<trainer>().HasData(
                new trainer { Id = 1, Name = "Rahul Sharma", ExperienceYears = 5 },
                new trainer { Id = 2, Name = "Priya Patel", ExperienceYears = 7 }
            );

            // Seed Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Title = ".NET Core", Fees = 25600, DurationinMonths = 6 },
                new Course { Id = 2, Title = "LINQ", Fees = 15500, DurationinMonths = 3 }
            );

            // Seed Students
            modelBuilder.Entity<student>().HasData(
                new student { Id = 1, Name = "Amit", Email = "amit@gmail.com", CreatedDate = DateTime.Now },
                new student { Id = 2, Name = "Neha", Email = "neha@gmail.com", CreatedDate = DateTime.Now },
                new student { Id = 3, Name = "Raj", Email = "raj@gmail.com", CreatedDate = DateTime.Now }
            );
        
       }
 



