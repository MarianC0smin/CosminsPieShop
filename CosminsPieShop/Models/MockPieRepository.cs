namespace CosminsPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie { PieId = 1, Name = "Strawberry Pie", Price = 15.95M, IsPieOfTheWeek = true}
            };

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return AllPies.Where(p => p.IsPieOfTheWeek);
            }
        }
        Pie? IPieRepository.GetPieById(int pieId) => AllPies.FirstOrDefault(p => p.PieId == pieId);
    }
}
