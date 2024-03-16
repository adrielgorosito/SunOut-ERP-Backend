﻿using SunOut_ERP_Backend.Domain;
using Microsoft.EntityFrameworkCore;

namespace SunOut_ERP_Backend.DataAccess
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=SunOutDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u => u.HasKey(user => user.username));
        }
    }
}
