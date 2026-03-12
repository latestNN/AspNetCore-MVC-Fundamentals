using Microsoft.AspNetCore.Mvc;

namespace P06_Layout.Controllers
{
    public class LayoutController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sayfa1()
        {
            return View();
        }
        public IActionResult Sayfa2()
        {
            return View();
        }
    }
}
