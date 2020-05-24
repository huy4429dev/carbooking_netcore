using CarBooking.Data.Configurations;
using CarBooking.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API

            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new CarConfigConfiguration());
            modelBuilder.ApplyConfiguration(new CarImageConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfigConfiguration());
            modelBuilder.ApplyConfiguration(new RouteConfigConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfigConfiguration());

            modelBuilder.Entity<ApplicationUser>()
                  .Property(b => b.Avatar)
                  .HasDefaultValue("/uploads/avatar_default.jpg");
            base.OnModelCreating(modelBuilder);
        }
    }
}