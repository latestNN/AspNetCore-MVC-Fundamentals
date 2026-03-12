using Microsoft.AspNetCore.Mvc;

namespace P07_Route_Yapilanmasi.Constraints
{
    [Route("[controller]/[action]")]
    [Route("ana/[action]")]
    public class AttributeRoutingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("in")]
        public IActionResult ActionBaseRouting()
        {
            return View();
        }

        [Route("in/{id?}")]
        public IActionResult CustomParamater(int id?)
        {
            return View();
        }
    }
}
 