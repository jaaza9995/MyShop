using Microsoft.AspNetCore.Mvc;

namespace MyShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}