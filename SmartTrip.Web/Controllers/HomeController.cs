using Microsoft.AspNetCore.Mvc;

namespace SmartTrip.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
} 