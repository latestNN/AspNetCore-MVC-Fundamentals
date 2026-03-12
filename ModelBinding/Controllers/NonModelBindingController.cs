using Microsoft.AspNetCore.Mvc;

namespace ModelBinding.Controllers
{
    public class NonModelBindingController : Controller
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
        public IActionResult CreateProduct(string txtProductName, string txtQuantity)
        {
            return View();
        }
    }
}
