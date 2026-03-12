using Microsoft.AspNetCore.Mvc;

namespace ModelBinding.Controllers
{
    public class ModelBindingController : Controller
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
        public IActionResult CreateProduct(Product product)
        {
            return View();
        }
    }
}
