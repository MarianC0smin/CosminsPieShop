using Microsoft.AspNetCore.Mvc;

namespace CosminsPieShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
