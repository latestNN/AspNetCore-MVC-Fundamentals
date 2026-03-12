using Microsoft.AspNetCore.Mvc;

namespace P11_Areas.Areas.yonetim_paneli.Controllers
{
    [Area("yonetim")] // Area Attribute'u
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AreaArasiVeriTasima()
        {
            var data = TempData["data"];
            return View();
        }
    }
}
 