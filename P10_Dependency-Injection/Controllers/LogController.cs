using Microsoft.AspNetCore.Mvc;
using P10_Dependency_Injection.Services;

namespace P10_Dependency_Injection.Controllers
{
    public class LogController : Controller
    {
        private readonly ILog _log;
        public LogController(ILog log)
        {
            _log = log;
        }

        

        public IActionResult Index()
        {
            // ConsoleLog log = new ConsoleLog(); Yanlış kullanım bağımlılık var.

            _log.Log(); // Program.cs içerisinde ILog üzerinden ConsoleLog sınıfı kayıt edildiği için burada ConsoleLog sınıfındaki Log fonksiyonu çalışacak.


            return View();
        }

        public IActionResult ActionBaseDI([FromServices]ILog log) // Action üzerinden Dependecy Injection kullanımı. FromServices Attribute'u ile istenilen nesneler çekilebilir.
        {
            log.Log();
            return View();
        }

        public IActionResult ViewBaseDI()
        {
            return View();
        }
    }
}
