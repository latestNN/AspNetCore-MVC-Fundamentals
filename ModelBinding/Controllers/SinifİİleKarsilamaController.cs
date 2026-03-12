using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace ModelBinding.Controllers
{
    public class SinifİİleKarsilamaController : Controller
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
