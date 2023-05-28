using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITTP.Domain;
using Microsoft.EntityFrameworkCore;

namespace ITTP.Persistance
{
    public class ITTPDbContext : DbContext
    {
        public ITTPDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = @"server=(localdb)\mssqllocaldb;database=TestDB;
                    integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Заранее создаю пользователя админ
            modelBuilder.Entity<User>()
                .HasData(new User
                {
                    Guid = Guid.NewGuid().ToString(),
                    Login = "admin",
                    Password = "asd123",
                    Name = "Николай",
                    Gender = 1,
                    Birthday = new DateTime(2003, 5, 2),
                    Admin = true,
                    CreatedBy = "database",
                    CreatedOn = DateTime.Now
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
