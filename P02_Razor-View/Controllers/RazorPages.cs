using Microsoft.AspNetCore.Mvc;

namespace P02_Razor_View.Controllers
{
    public class RazorPages : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
