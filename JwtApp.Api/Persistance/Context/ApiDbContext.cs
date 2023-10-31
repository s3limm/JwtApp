using JwtApp.Api.Core.Domain;
using JwtApp.Api.Persistance.Configuration;
using Microsoft.EntityFrameworkCore;

namespace JwtApp.Api.Persistance.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext()
        {

        }
        public ApiDbContext(DbContextOptions<ApiDbContext> option) : base(option)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=JwtAppApiDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }

        public DbSet<AppRole> AppRoles => this.Set<AppRole>();
        public DbSet<AppUser> AppUsers => this.Set<AppUser>();
        public DbSet<Category> Categories => this.Set<Category>();
        public DbSet<Product> Products => this.Set<Product>();
    }
}
