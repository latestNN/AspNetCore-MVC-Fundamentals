using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using P05._03_Tuple_Nesne_Post_Yakalma_Islemleri.Models;

namespace P05._03_Tuple_Nesne_Post_Yakalma_Islemleri.Controllers
{
    public class TupleController : Controller
    {
        public IActionResult GetProduct()
        {
            return View();
        }

        public IActionResult CreateProduct()
        {
            var tuple = (new Product(), new User());
            return View(tuple);
        }

        [HttpPost]
        public IActionResult CreateProduct([Bind(Prefix = "Item1")] Product product, [Bind(Prefix ="Item2")] User user)
        {
            return View();
        }
    }
}
