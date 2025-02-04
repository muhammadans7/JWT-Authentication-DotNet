using Microsoft.EntityFrameworkCore;
using jwt.models;

namespace jwt.data{

    public class AppDbContext : DbContext{

        public DbSet<User> Users { get; set; }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Why;Database=jwtdemo;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}