using HomeEconomyApi.Core.Entities;
using HomeEconomyApi.Core.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HomeEconomyApi.Infrastructure.Data
{
    public class HomeEconomyDBContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public HomeEconomyDBContext(DbContextOptions<HomeEconomyDBContext> options)
           : base(options)
        {
        }

        public DbSet<Installment>? Installments { get; set; }
        public DbSet<Purchase>? Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
