using Microsoft.AspNetCore.Mvc;

namespace P05._01_Form_ile_Veri_Alma.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProduct()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VeriAl(IFormCollection datas) // Parametre - Sinif - ModelBinding disindaki yontem
        {
            var value1 = datas["txtValue1"].ToString();
            var value2 = datas["txtValue2"].ToString();
            var value3 = datas["txtValue3"].ToString();
            return View();
        }
    }
}
