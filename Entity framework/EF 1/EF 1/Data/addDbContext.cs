using EF_1.Data;
using EF_1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_1.Data
{
    public class addDbContext : DbContext
    {
        public DbSet<student> students { get; set; }

        public DbSet<Course> courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = LAPTOP - FFPI4CQG\\SQLEXPRESS01x; Database = Entityframework01, trust_Connection = true; TrustServerConnection = True");
        }
    } 
}
