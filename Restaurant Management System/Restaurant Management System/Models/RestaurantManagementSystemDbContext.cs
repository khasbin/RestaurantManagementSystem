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
                .HasOne(u => u.SeatingPreference)
                .WithOne(sp => sp.User)
                .HasForeignKey<SeatingPreference>(sp => sp.Id);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Reservations)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.Id);

            modelBuilder.Entity<MenuItem>()
                .HasMany(mi => mi.DailySpecials)
                .WithOne(ds => ds.MenuItem)
                .HasForeignKey(ds => ds.MenuItemId);

            modelBuilder.Entity<Reservation>()
                .HasMany(r => r.ReservationHistories)
                .WithOne(rh => rh.Reservation)
                .HasForeignKey(rh => rh.ReservationId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
