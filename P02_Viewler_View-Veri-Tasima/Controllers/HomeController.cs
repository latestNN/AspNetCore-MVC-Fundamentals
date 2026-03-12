using Microsoft.AspNetCore.Mvc;
using P02_Viewler_View_Veri_Tasima.Models;
using System.Diagnostics;

namespace P02_Viewler_View_Veri_Tasima.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return PartialView();
        }

        

         
    }
}
