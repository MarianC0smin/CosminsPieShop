using CosminsPieShop.Models;

namespace CosminsPieShop
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
