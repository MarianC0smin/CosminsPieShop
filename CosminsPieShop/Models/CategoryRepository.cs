namespace CosminsPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CosminsPieShopDbContext _cosminsPieShopDbContext;

        public CategoryRepository(CosminsPieShopDbContext bethanysPieShopDbContext)
        {
            _cosminsPieShopDbContext = bethanysPieShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _cosminsPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
