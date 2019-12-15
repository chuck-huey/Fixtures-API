using System;
using System.Linq;
using AvisAPI.Domain.Contracts;
using AvisAPI.Domain.Entities;
using AvisAPI.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AvisAPI.DbContext
{
    public class AvisDbContext : IdentityDbContext<AppUser>
    {
        public AvisDbContext(DbContextOptions<AvisDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Fixture> Fixtures { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new { Id = "2", Name = "User", NormalizedName = "USER" }
            );
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added
                || e.State == EntityState.Modified);

            foreach (var entry in entries)
            {
                var entity = entry.Entity as IEntity;
                entity.UpdatedAt = DateTimeOffset.Now;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedAt = DateTimeOffset.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
