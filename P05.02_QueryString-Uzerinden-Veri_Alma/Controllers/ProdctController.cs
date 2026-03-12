using Microsoft.AspNetCore.Mvc;

namespace P05._02_QueryString_Uzerinden_Veri_Alma.Controllers
{
    public class ProdctController : Controller
    {
        public class QueryData
        {
            public string Name { get; set; }
            public string Quantity { get; set; }

        }

        public IActionResult VeriAlParametre(string a, string b) // Product/VeriAlParametre?name=Kalem&quantity=5
        {
            return View();
        }
        public IActionResult VeriAlRequest() // Product/VeriAlParametre?name=Kalem&quantity=5
        {
            var NameData = Request.Query["name"];
            var QuantityData = Request.Query["quantity"];
            return View();
        }
        public IActionResult VeriAlClass(QueryData query) // Product/VeriAlParametre?name=Kalem&quantity=5
        {
            var NameData = query.Name;
            var QuantityData = query.Quantity;
            return View();
        }

    }
}
