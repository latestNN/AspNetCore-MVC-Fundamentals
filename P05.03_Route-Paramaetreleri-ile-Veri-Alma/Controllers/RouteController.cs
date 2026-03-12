using Microsoft.AspNetCore.Mvc;

namespace P05._03_Route_Paramaetreleri_ile_Veri_Alma.Controllers
{
    public class RouteController : Controller
    {
        public class RouteData
        {
            public string A { get; set; }
            public string B { get; set; }
            public string Id { get; set; }
        }
        public IActionResult VeriAlParametre(int id) // Route/VeriAlParametre/5   -- Default Route ayarinda son parametrinin ismi id oldugu icin bu parametreye de id ismi verildi.
        {
            return View();
        }

        public IActionResult VeriAlReuest()
        {
            var values = Request.RouteValues;  // Route/VeriAlParametre/5
            return View();
        }
        public IActionResult VeriAlClass(RouteData data) // Route/VeriAlParametre/5
        {
            var a = data.A;  
            var b = data.B;  
            var id = data.Id;  
            return View();
        }

        public IActionResult RouteParametreOlsutur() 
        {

            return View();
        }


    }
}
