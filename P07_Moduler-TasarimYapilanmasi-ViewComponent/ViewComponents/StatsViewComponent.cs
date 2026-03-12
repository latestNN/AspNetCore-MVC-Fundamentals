using Microsoft.AspNetCore.Mvc;
using P07_Moduler_TasarimYapilanmasi_ViewComponent.Models;

namespace P07_Moduler_TasarimYapilanmasi_ViewComponent.ViewComponents
{
    public class StatsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int veri) // Ana View'den gelen veri isimli ananom türü karşılar.
        {
            List<Stats> data = new List<Stats>
            {
                new Stats { Id = 1, ActiveUser = 100 },
                new Stats { Id = 2, ActiveUser = 200 },
                new Stats { Id = 3, ActiveUser = 300 },
            };
            ViewBag.Veri = veri;
            return View(data);
        }
    }
}
