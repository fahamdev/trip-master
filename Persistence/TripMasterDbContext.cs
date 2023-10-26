using Domain.Base;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class TripMasterDbContext : DbContext
    {
        public TripMasterDbContext(DbContextOptions<TripMasterDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TripMasterDbContext).Assembly);

            //seed Organization
            var travelmateGuid = Guid.Parse("{d590df59-396b-46fe-af30-13ebfca9f709}");
            var abcToursGuid = Guid.Parse("{7afa79ba-fb56-416b-b19d-840b63c0e944}");

            modelBuilder.Entity<Organization>().HasData(new Organization
            {
                Id = travelmateGuid,
                Name = "Travel Mate Ltd"
            });
            modelBuilder.Entity<Organization>().HasData(new Organization
            {
                Id = abcToursGuid,
                Name = "ABC Tours Ltd"
            });


            //seed Categories
            var dayTripGuid = Guid.Parse("{cc234330-71cf-40bf-a3e3-2d03feddab55}");
            var hikingGuid = Guid.Parse("{97fbc25c-6167-487e-b6ea-d8df80ddc4d7}");
            var relaxationGuid = Guid.Parse("{dbda7582-23e4-43d7-8f06-07c9d7798c3e}");
            var riverCruiseGuid = Guid.Parse("{c62d2f1f-f62b-44ed-8e91-46c0340146f3}");

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = dayTripGuid,
                Name = "Day Trip"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = hikingGuid,
                Name = "Hiking"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = relaxationGuid,
                Name = "Relaxation"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = riverCruiseGuid,
                Name = "River Cruise"
            });

            //seed Trips
            modelBuilder.Entity<Trip>().HasData(new Trip
            {
                Id = Guid.Parse("{d6904018-b707-49c2-a2e4-83e9224f1eb9}"),
                Name = "Sarah Resort Day Tour",
                Slug = "sarah-resort-day-tour",
                Description = "Day long tour in the Sarah Resort",
                StartDate = DateTime.Now.AddDays(10),
                EndDate = DateTime.Now.AddDays(10),
                CategoryId = dayTripGuid,
                OrganizationId = travelmateGuid
            });
            modelBuilder.Entity<Trip>().HasData(new Trip
            {
                Id = Guid.Parse("{886fbd66-d09b-49f1-8177-56c6385a7ac4}"),
                Name = "Sarah Resort Short Stay",
                Slug = "sarah-resort-short-stay",
                Description = "Three day two night stay in the Sarah Resort",
                StartDate = DateTime.Now.AddDays(10),
                EndDate = DateTime.Now.AddDays(12),
                CategoryId = relaxationGuid,
                OrganizationId = travelmateGuid
            });
            modelBuilder.Entity<Trip>().HasData(new Trip
            {
                Id = Guid.Parse("{89d2d0b8-cd1c-43f3-b428-37cccf741ca0}"),
                Name = "Sundarban Tour",
                Slug = "sundarban-tour",
                Description = "River cruise in the Sundarbans",
                StartDate = DateTime.Now.AddDays(20),
                EndDate = DateTime.Now.AddDays(23),
                CategoryId = riverCruiseGuid,
                OrganizationId = abcToursGuid
            });
            modelBuilder.Entity<Trip>().HasData(new Trip
            {
                Id = Guid.Parse("{90f673f3-84fa-427c-b2f9-db62ca5d569b}"),
                Name = "Bandarban Tour",
                Slug = "bandarban-tour",
                Description = "Hiking in the Bandarban",
                StartDate = DateTime.Now.AddDays(20),
                EndDate = DateTime.Now.AddDays(23),
                CategoryId = hikingGuid,
                OrganizationId = abcToursGuid
            });

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedAt = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.UpdatedAt = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }


    }
}
