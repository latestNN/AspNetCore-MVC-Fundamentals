using Microsoft.AspNetCore.Mvc;
using P02_Viewler_View_Veri_Tasima.Models;
using P02_Viewler_View_Veri_Tasima.Models.ViewModels;
using System.Text.Json;

namespace P02_Viewler_View_Veri_Tasima.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ModelBased()
        {
            #region Model Bazlı Veri Taşıma
            var product = new List<Product>
            {
                new Product{ ID=1, ProductName="Laptop", Quantity=5},
                new Product{ ID=2, ProductName="Mouse", Quantity=15},
                new Product{ ID=3, ProductName="Keyboard", Quantity=8},
                new Product{ ID=4, ProductName="Monitor", Quantity=12},
                new Product{ ID=5, ProductName="Printer", Quantity=4}
            };
            return View(product);
            #endregion
        }

        public IActionResult ViewBagBased()
        {
            #region ViewBag Bazlı Veri Taşıma
            var product = new List<Product>
            {
                new Product{ ID=1, ProductName="Laptop", Quantity=5},
                new Product{ ID=2, ProductName="Mouse", Quantity=15},
                new Product{ ID=3, ProductName="Keyboard", Quantity=8},
                new Product{ ID=4, ProductName="Monitor", Quantity=12},
                new Product{ ID=5, ProductName="Printer", Quantity=4}
            };
            ViewBag.products = product; // Dynamic turde calisir.
            return View();
            #endregion
        }

        public IActionResult ViewDataBased()
        {
            #region ViewData Bazlı Veri Taşıma
            var product = new List<Product>
            {
                new Product{ ID=1, ProductName="Laptop", Quantity=5},
                new Product{ ID=2, ProductName="Mouse", Quantity=15},
                new Product{ ID=3, ProductName="Keyboard", Quantity=8},
                new Product{ ID=4, ProductName="Monitor", Quantity=12},
                new Product{ ID=5, ProductName="Printer", Quantity=4}
            };
            ViewData["product"] = product; // Boxing ile calisir.
            return View();
            #endregion
        }

        public IActionResult TempDataBased()
        {
            #region TempData Bazlı Veri Taşıma
            var product = new List<Product>
            {
                new Product{ ID=1, ProductName="Laptop", Quantity=5},
                new Product{ ID=2, ProductName="Mouse", Quantity=15},
                new Product{ ID=3, ProductName="Keyboard", Quantity=8},
                new Product{ ID=4, ProductName="Monitor", Quantity=12},
                new Product{ ID=5, ProductName="Printer", Quantity=4}
            };

            string data = JsonSerializer.Serialize(product); // Complex tipler ile TempData kullanmak icin serialization yapilabilir.
            TempData["products"] = data; // Boxing ile calisir.
            return RedirectToAction("TempDataBased2");
            #endregion
        }

        public IActionResult TempDataBased2()
        {
            #region TempData ile Action arasi Veri Taşıma
            var data = TempData["products"].ToString(); // Cast edilmiyor sadece nesneye ulasilarak string'e donusturuluyor.
            List<Product> product = JsonSerializer.Deserialize<List<Product>>(data); // Deserialization yapilarak tekrar orjinal tipe donusturuluyor.
            return View();
            #endregion
        }


        public IActionResult ViewModelBased()
        {
            Product product = new Product 
            { 
                ID = 1, 
                ProductName = "Laptop",
                Quantity = 5
            };

            User user = new User
            {
                Id = 1,
                Name = "John",
                LastName = "Doe"
            };

            var userProduct = new UserProduct
            {
                Product = product,
                User = user
            };
            return View(userProduct);
        }


        public IActionResult TupleBased()
        {
            Product product = new Product
            {
                ID = 1,
                ProductName = "Laptop",
                Quantity = 5
            };

            User user = new User
            {
                Id = 1,
                Name = "John",
                LastName = "Doe"
            };

            var userProduct = (product, user);

            return View(userProduct);
        }
    }
}
