namespace CosminsPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CosminsPieShopDbContext _bethanysPieShopDbContext;

        public CategoryRepository(CosminsPieShopDbContext bethanysPieShopDbContext)
        {
            _bethanysPieShopDbContext = bethanysPieShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _bethanysPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
