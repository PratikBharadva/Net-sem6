using Assignment1.Model;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Data
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Bill> Bills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Menu>().HasKey(m => m.FoodId);
            modelBuilder.Entity<Order>().HasKey(m => m.OrderId);
            modelBuilder.Entity<Bill>().HasKey(m => m.BillId);
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Food)
                .WithMany(of => of.orders)
                .HasForeignKey(o => o.FoodId);
            modelBuilder.Entity<Order>()
                .HasOne(o => o.bills)
                .WithMany(of => of.Order)
                .HasForeignKey(o => o.BillId);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RestaurantDB;Integrated Security=True;");
        }
        
    }
}
