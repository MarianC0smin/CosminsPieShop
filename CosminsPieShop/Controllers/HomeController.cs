using CosminsPieShop.Models;
using CosminsPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CosminsPieShop.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository= pieRepository;
        }

        private readonly IPieRepository _pieRepository;
        public IActionResult Index()
        {
            var piesOfTheWeek = _pieRepository.PiesOfTheWeek;
            var homeViewModel = new HomeViewModel(piesOfTheWeek);
            return View(homeViewModel);
        }
    }
}
