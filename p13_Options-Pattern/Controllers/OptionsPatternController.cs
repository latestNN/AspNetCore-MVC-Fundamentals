using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using p13_Options_Pattern.Models;

namespace p13_Options_Pattern.Controllers
{
    public class OptionsPatternController : Controller
    {
        private readonly IConfiguration _configuration;
        
        MailInfo _mailInfo;

        public OptionsPatternController(IConfiguration configuration, IOptions<MailInfo> mailInfo)
        {
            _configuration = configuration; // Uzun yöntem.
            _mailInfo = mailInfo.Value;
        }

        public IActionResult Index()
        {
            MailInfo mailInfo = _configuration.GetSection("MailInfo").Get<MailInfo>(); // Uzun yöntem


            return View();
        }

        public IActionResult OptionsPattern()
        {

            return View();
        }
    }
}
