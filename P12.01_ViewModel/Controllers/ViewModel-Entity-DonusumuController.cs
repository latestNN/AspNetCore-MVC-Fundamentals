using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using P12._01_ViewModel.Business_Reflection_;
using P12._01_ViewModel.Models;
using P12._01_ViewModel.ViewModels;

namespace P12._01_ViewModel.Controllers
{
    public class ViewModel_Entity_DonusumuController : Controller
    {
        private readonly IMapper _mapper;

        public ViewModel_Entity_DonusumuController(IMapper mapper)
        {
            _mapper = mapper; 
        }
        [HttpPost]
        public IActionResult ManuelDonusturme(PersonelCreateViewModel model)
        {
            Personel p = new Personel()
            {
                Name = model.Name,
                LastName = model.LastName
            };
            // Save Database
            return View();
        }

        [HttpPost]
        public IActionResult ImplicitDonusturme(PersonelCreateViewModel model)
        {
            Personel personel = model;
            PersonelCreateViewModel vm = personel; // Ters dönüşüm
            // Save Database
            return View();
        }

        [HttpPost]
        public IActionResult ExplicitDonusturme(PersonelCreateViewModel model)
        {
            Personel personel = (Personel)model;
            PersonelCreateViewModel vm = (PersonelCreateViewModel)personel; // Ters dönüşüm
            // Save Database
            return View();
        }

        [HttpPost]
        public IActionResult ReflectionDonusturme(PersonelCreateViewModel model)
        {

            Personel p = TypeConversion.Conversion<PersonelCreateViewModel, Personel>(model);
           
            // Save Database
            return View();
        }
         
        [HttpPost]
        public IActionResult AutoMapperDonusturme(PersonelCreateViewModel model)
        {

            Personel p = _mapper.Map<Personel>(model);
            PersonelCreateViewModel vm = _mapper.Map<PersonelCreateViewModel>(p); // Ters Dönüşüm
           
            // Save Database
            return View();
        }
    }
}
