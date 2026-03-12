using Microsoft.AspNetCore.Mvc;

namespace P07_Moduler_TasarimYapilanmasi_ViewComponent.Controllers
{
    public class AnaMenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
