using Microsoft.EntityFrameworkCore;

namespace CosminsPieShop.Models
{
    public class CosminsPieShopDbContext: DbContext
    {
        public CosminsPieShopDbContext(DbContextOptions<CosminsPieShopDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
