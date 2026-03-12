using Microsoft.AspNetCore.Mvc;
using P05._04_Server_Validationlari_Cilent_Tabanlı_Uygulama.Models;

namespace P05._04_Server_Validationlari_Cilent_Tabanlı_Uygulama.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product model)
        {
            if (!ModelState.IsValid) //Validation'lar dogrulanmazsa
            {
                //Kullanici bilgilendirmesi
                //Loglama vs.


                return View(model);
            }
            return View();
        }
    }
}
