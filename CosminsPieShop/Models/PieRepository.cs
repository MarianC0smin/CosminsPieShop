using Microsoft.EntityFrameworkCore;

namespace CosminsPieShop.Models
{
    public class PieRepository:IPieRepository
    {
        private readonly CosminsPieShopDbContext _cosminsPieShopDbContext;

        public PieRepository(CosminsPieShopDbContext cosminsPieShopDbContext)
        {
            _cosminsPieShopDbContext = cosminsPieShopDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _cosminsPieShopDbContext.Pies.Include(c =>c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _cosminsPieShopDbContext.Pies.Include(c => c.Category).Where(p =>p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _cosminsPieShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            return _cosminsPieShopDbContext.Pies.Where(p =>p.Name.Contains(searchQuery));
        }
    }
}
