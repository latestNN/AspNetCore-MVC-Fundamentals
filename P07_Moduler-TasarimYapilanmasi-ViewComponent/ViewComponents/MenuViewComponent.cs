using Microsoft.AspNetCore.Mvc;

namespace P07_Moduler_TasarimYapilanmasi_ViewComponent.ViewComponents
{
    //[NonViewComponent] ViewComponent olarak kullanılmasını istemediğimiz bir sınıfı bu şekilde işaretleyebiliriz.
    public class MenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<string> menu = new List<string>
            {
                "Dashboard",
                "Siparişler",
                "Müşteriler",
                "Raporlar"
            };

            return View(menu);
        }
    }
}
