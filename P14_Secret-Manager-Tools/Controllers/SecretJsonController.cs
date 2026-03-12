using Microsoft.AspNetCore.Mvc;

namespace P14_Secret_Manager_Tools.Controllers
{
    
    public class SecretJsonController : Controller
    {
        // C: / kullanıcılar / kullanıcı(aliberr) / AppData(Gizli olabiliyor) / Roaming / Microsoft / UserSecrets Dizininde Development ortamındaki secrets.json dosyaları tutulur.
        private readonly IConfiguration _configuration;

        public SecretJsonController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var kullanici = _configuration["MailBilgileri:Kullanici"];
            var sifre = _configuration["MailBilgileri:Sifre"];
            return View();
        }
    }
}
