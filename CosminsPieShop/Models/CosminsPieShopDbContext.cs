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
    }
}
