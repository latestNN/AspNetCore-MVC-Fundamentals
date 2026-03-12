using Microsoft.AspNetCore.Mvc;

namespace P05._03_Route_Paramaetreleri_ile_Veri_Alma.Controllers
{
    public class CustomRouteController : Controller
    {
        public IActionResult VeriAl(string id, string c, string a, string b) // siralamanin bir onemi yoktur. -- Route/CustomRoute/VeriAl/a/b/c/123
        {
            return View();
        }
    }
}
