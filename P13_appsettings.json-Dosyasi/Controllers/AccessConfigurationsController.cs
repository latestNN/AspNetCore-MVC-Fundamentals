using Microsoft.AspNetCore.Mvc;
using P13_appsettings.json_Dosyasi.Models;

namespace P13_appsettings.json_Dosyasi.Controllers
{
    public class AccessConfigurationsController : Controller
    {
        private readonly IConfiguration _configuration;

        public AccessConfigurationsController(IConfiguration configuration)
        {
            _configuration = configuration;            
        }

        public IActionResult GetValueWithIndexerFromAppsettings()
        {
            string v1 = _configuration["OrnekMetin"];

            var v2 = _configuration["Person"]; // Person json dosyasında obje olduğu için Null döner.
            var v3 = _configuration["Person:Name"];
            var v4 = _configuration["Person:Surname"];


            var v5 = _configuration["Logging:LogLevel:Microsoft.Hosting.Lifetime"]; 



            return View();
        }

        public IActionResult GetValueWithGetSectionFromAppsettings()
        { 
            var v1  = _configuration.GetSection("Person"); // Null dönmez konfigürasyon alanı döner.
            var v2 = _configuration.GetSection("Person:Name");
            string metin = v2.Value;
            return View();
        }
        public IActionResult VerileriNesneIleEsletirme()
        {
            var v8 = _configuration.GetSection("Person").Get(typeof(Person));
             
            return View();
        }
    }
}
