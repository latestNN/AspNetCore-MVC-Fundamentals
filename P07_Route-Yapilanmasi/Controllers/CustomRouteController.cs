using Microsoft.AspNetCore.Mvc;

namespace P07_Route_Yapilanmasi.Controllers
{
    public class CustomRouteController : Controller
    {
        public IActionResult Index(string x, string y, string id) // Eğer Raoute Constrains yoksa karşılanabilecek en geniş tür ile karşılamak daha doğrudur. Çünkü Request'den ne geleceği bilinemez.
        {
            return View();
        }

        public IActionResult TypeSafeRoute(int id, string name) // Karşılanabilecek en geniş tür ile karşılamak daha doğrudur. Çünkü Request'den ne geleceği bilinemez.
        {
            return View();
        }
    }
}
