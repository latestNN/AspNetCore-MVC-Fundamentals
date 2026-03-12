using Microsoft.AspNetCore.Mvc;
using P05._01_Validation.Models;

namespace P05._01_Validation.Controllers
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

