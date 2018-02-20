using Microsoft.AspNetCore.Mvc;

namespace Zadatak.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}