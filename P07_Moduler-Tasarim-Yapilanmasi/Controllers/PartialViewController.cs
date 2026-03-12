using Microsoft.AspNetCore.Mvc;

namespace P07_Moduler_Tasarim_Yapilanmasi.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult Index()
        {
            var images = new List<string> { "img1.jpg", "img2.jpg", "img3.jpg"};
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            ViewBag.Numbers = numbers;
            return View(images);
        }
    }
}
