using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    
      
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Customer>().HasData(
            new List<Customer>()
            {
                new Customer(1, "Ardasher", "Sattori", "Dushanbe", "881933339", "ardasher@icloud.com"),
                new Customer(2, "Abdullah", "Sheralizoda", "Asht", "000000000", "abdullah@gmail.com"),
                new Customer(3, "Anushervon", "Bekov", "Kulob", "000000000", "anushervon@gmail.com"),
                new Customer(4, "Sherzod", "Ishankulov", "Dushanbe", "000000000", "sherzod@gmail.com"),
            });
        modelBuilder.Entity<Order>().HasData(
            new List<Order>()
            {
                new Order(1, DateTime.UtcNow, DateTime.UtcNow, 1),
                new Order(2, DateTime.UtcNow, DateTime.UtcNow, 2),
                new Order(3, DateTime.UtcNow, DateTime.UtcNow, 3),
                new Order(4, DateTime.UtcNow, DateTime.UtcNow, 4),
                
            });
        modelBuilder.Entity<OrderDetail>().HasData(
            new List<OrderDetail>()
            {
                new OrderDetail(1, 1, 1, 1),
                new OrderDetail(2, 2, 2, 2),
                new OrderDetail(3, 3, 3, 3),
                new OrderDetail(4, 4, 4, 4),
            });
        modelBuilder.Entity<Product>().HasData(
            new List<Product>()
            {
                new Product(1, "Lexus", 10000),
                new Product(2, "Mercedes", 20000),
                new Product(3, "Audi", 30000),
                new Product(4, "Bmw", 40000),
            });
        
        
        
        base.OnModelCreating(modelBuilder);

    }
}