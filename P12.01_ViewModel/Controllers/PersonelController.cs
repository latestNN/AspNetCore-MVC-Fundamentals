using Microsoft.AspNetCore.Mvc;
using P12._01_ViewModel.Models;
using P12._01_ViewModel.ViewModels;

namespace P12._01_ViewModel.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonelCreateViewModel personelCreateViewModel)
        {
            return View();
        }

        public IActionResult Listele()
        {
            List<PersonelListViewModel> personeller = new List<Personel>
            {
                new Personel{Name = "Ahmet", LastName = "Yılmaz"},
                new Personel{Name = "Mehmet", LastName = "Yılmaz"},
                new Personel{Name = "Mahmut", LastName = "Yılmaz"},
                new Personel{Name = "Metin", LastName = "Yılmaz"}
            }.Select(p => new PersonelListViewModel
            {
                Name = p.Name,
                LastName = p.LastName,
                Department = p.Department
            }).ToList(); 

            return View(personeller);
        }


        public IActionResult Get()
        {
            MergeViewModel model = new MergeViewModel
            {
                Personel = new Personel { Name = "Ahmet", LastName = "Yılmaz", Department = "IT" },
                Urun = new Urun { },
                Musteri = new Musteri { }
            };
            return View(model);
        }

        
    }
}
