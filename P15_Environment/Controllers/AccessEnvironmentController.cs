using Microsoft.AspNetCore.Mvc;

namespace P15_Environment.Controllers
{
    public class AccessEnvironmentController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;

        public AccessEnvironmentController(IWebHostEnvironment webHostEnvironment, IConfiguration configuration)
        {
            _webHostEnvironment = webHostEnvironment;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            _webHostEnvironment.IsDevelopment(); // Proje Development Environment'da çalışıyorsa True dönecektir.
            _webHostEnvironment.IsStaging(); // Proje Staging Environment'da çalışıyorsa True dönecektir.
            _webHostEnvironment.IsProduction(); // Proje Production Environment'da çalışıyorsa True dönecektir.

            _webHostEnvironment.IsEnvironment("Ahmet"); // Proje Custom Environment'da çalışıyorsa kullanılır. Proje Ahmet ortamında çalışıyorsa True dönecektir.

            return View();
        }

        public IActionResult EnvironmnetViewer()
        {
            if(_webHostEnvironment.IsDevelopment())
            {
                ViewBag.Env = "Development";
            }
            else if(_webHostEnvironment.IsStaging())
            {
                ViewBag.Env = "Staging";
            }
            else if(_webHostEnvironment.IsProduction())
            {
                ViewBag.Env = "Production";
            }
            else if(_webHostEnvironment.IsEnvironment("Ahmet"))
            {
                ViewBag.Env = "Ahmet";
            }
            return View();
        }

        public IActionResult AccessEnvironmentVariables()
        {
            var a =  _configuration["A"];

            return View();
        }

        public IActionResult OverrideFiles()
        {
            var Veriable = _configuration["A"]; // A Environment(Environment Variable) gelir. Orada yoksa A secret(secret.json) gelir. Orada da yoksa A appsettings(appsettings.json) gelir.
            return View();
        }
    }
}
