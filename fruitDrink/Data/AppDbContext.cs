using fruitDrink.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace fruitDrink.Data
{
    public class AppDbContext :IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) {







        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Drink>()
                .Property(p => p.price)
                .HasColumnType("decimal(18,4)");
            modelBuilder.Entity<OrderDetail>()
                .Property(p => p.Price)
                .HasColumnType("decimal()");
            modelBuilder.Entity<Order>()
               .Property(p => p.OrderTotal)
               .HasColumnType("decimal(18.4)");

        }


        public DbSet<Drink>? Drinks { get; set; }

        public DbSet<category> Categories { get; set; }

        public DbSet<ShoppingCartItems> ShoppingCartItems { get; set;}

        public DbSet<Order>? Orders { get; set; }

        public DbSet<OrderDetail>? OrderDetails { get; set; }
    }
}
