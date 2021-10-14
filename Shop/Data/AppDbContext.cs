
using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
    }
}