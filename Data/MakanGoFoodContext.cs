using CarRentalManagement.Configurations.Entities;
using MakanGoFood.Configurations.Entities;
using MakanGoFood.Data;
using MakanGoFood.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MakanGoFood.Data
{
    public class MakanGoFoodContext(DbContextOptions<MakanGoFoodContext> options) : IdentityDbContext<MakanGoFoodUser>(options)
    {
        public DbSet<Order> Order { get; set; } = default!;
        public DbSet<Address> Address { get; set; } = default!;
        public DbSet<Customer> Customer { get; set; } = default!;
        public DbSet<DeliveryRider> DeliveryRider { get; set; } = default!;
        public DbSet<Menu> Menu { get; set; } = default!;
        public DbSet<OrderItem> OrderItem { get; set; } = default!;
        public DbSet<Payment> Payment { get; set; } = default!;
        public DbSet<Restaurant> Restaurant { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Customer -> Address (ok to cascade)
            modelBuilder.Entity<Address>()
                .HasOne(a => a.Customer)
                .WithMany()
                .HasForeignKey(a => a.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            // Order FKs: stop cascade paths (important)
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany()
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Address)
                .WithMany()
                .HasForeignKey(o => o.AddressId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Rider)
                .WithMany()
                .HasForeignKey(o => o.RiderId)
                .OnDelete(DeleteBehavior.NoAction); // or SetNull if RiderId is nullable

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Restaurant)
                .WithMany()
                .HasForeignKey(o => o.RestaurantId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.ApplyConfiguration(new MenuSeed());
            modelBuilder.ApplyConfiguration(new RestaurantSeed());
            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserRoleSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());

        }
    }
}

