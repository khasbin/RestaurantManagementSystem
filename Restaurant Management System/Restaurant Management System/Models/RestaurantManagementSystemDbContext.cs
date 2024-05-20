using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Restaurant_Management_System.Models
{
    public class RestaurantManagementSystemDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public RestaurantManagementSystemDbContext(DbContextOptions<RestaurantManagementSystemDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<DailySpecial> DailySpecials { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationHistory> ReservationHistories { get; set; }
        public DbSet<SeatingPreference> SeatingPreferences { get; set; }
        public DbSet<Reports> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Reservations)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.Id);

            modelBuilder.Entity<MenuItem>()
                .HasMany(mi => mi.DailySpecials)
                .WithOne(ds => ds.MenuItem)
                .HasForeignKey(ds => ds.MenuItemId);

            modelBuilder.Entity<ReservationHistory>()
                .HasMany(u => u.Reservations)
                .WithOne(r => r.ReservationHistory)
                .HasForeignKey(r => r.ReservationId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
