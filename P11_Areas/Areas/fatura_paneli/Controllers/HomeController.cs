using Microsoft.AspNetCore.Mvc;

namespace P11_Areas.Areas.fatura_paneli.Controllers
{
    [Area("fatura_paneli")] // Area Attribute'u
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AreaArasiBaglanti()
        {
            return View();
        }
        public IActionResult AreaArasiVeriTasima()
        {
            TempData["veri"] = "Fatura Panelinden gelen veri";
            return RedirectToAction("Index", "Home", new {area = "fatura_yonetimi"});
        }
    }
}
