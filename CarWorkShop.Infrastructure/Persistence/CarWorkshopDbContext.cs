using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace CarWorkshop.Infrastructure.Persistence
{
    public class CarWorkshopDbContext : DbContext
    {
        public CarWorkshopDbContext(DbContextOptions<CarWorkshopDbContext> options) : base(options)
        {
            CarWorkshops = Set<CarWorkshop.Domain.Entities.CarWorkshop>();
        }

        public DbSet<CarWorkshop.Domain.Entities.CarWorkshop> CarWorkshops { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet(CharSet.Utf8Mb4, DelegationModes.ApplyToColumns);
            modelBuilder.UseCollation("utf8mb4_unicode_ci", DelegationModes.ApplyToColumns);
            modelBuilder.Entity<CarWorkshop.Domain.Entities.CarWorkshop>()
                .OwnsOne(c => c.ContactDetails);
        }
    }
}
