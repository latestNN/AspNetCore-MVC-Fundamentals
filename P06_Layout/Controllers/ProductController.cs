using Microsoft.AspNetCore.Mvc;

namespace P06_Layout_Yapilari-ViewStartDosyasi-ViewImportDosyasi.Controllers
{
    public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}
