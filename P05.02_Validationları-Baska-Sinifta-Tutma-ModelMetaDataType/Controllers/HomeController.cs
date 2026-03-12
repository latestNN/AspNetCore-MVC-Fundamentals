using Microsoft.AspNetCore.Mvc;
using P05._02_Validationları_Baska_Sinifta_Tutma_ModelMetaDataType.Models;
using System.Diagnostics;

namespace P05._02_Validationları_Baska_Sinifta_Tutma_ModelMetaDataType.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
