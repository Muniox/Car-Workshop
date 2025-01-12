using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace CarWorkshop.Infrastructure.Persistence
{
    public class CarWorkshopDbContext : IdentityDbContext
    {
        public CarWorkshopDbContext(DbContextOptions<CarWorkshopDbContext> options) : base(options)
        {
            CarWorkshops = Set<CarWorkshop.Domain.Entities.CarWorkshop>();
            Services = Set<CarWorkshop.Domain.Entities.CarWorkshopService>();
        }

        public DbSet<Domain.Entities.CarWorkshop> CarWorkshops { get; set; }
        public DbSet<Domain.Entities.CarWorkshopService> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasCharSet(CharSet.Utf8Mb4, DelegationModes.ApplyToColumns);
            modelBuilder.UseCollation("utf8mb4_unicode_ci", DelegationModes.ApplyToColumns);
            modelBuilder.Entity<CarWorkshop.Domain.Entities.CarWorkshop>()
                .OwnsOne(c => c.ContactDetails);

            // dodawanie relacji fluent api
            modelBuilder.Entity<CarWorkshop.Domain.Entities.CarWorkshop>()
                .HasMany(c => c.Services)
                .WithOne(c => c.CarWorkshop)
                .HasForeignKey(s => s.CarWorkshopId);
        }
    }
}
