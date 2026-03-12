using AutoMapper;
using P12._01_ViewModel.Models;
using P12._01_ViewModel.ViewModels;

namespace P12._01_ViewModel.AutoMappers
{
    public class PersonelProfil : Profile 
    {
        public PersonelProfil()
        {
            CreateMap<Personel, PersonelCreateViewModel>();
            CreateMap<PersonelCreateViewModel, Personel>(); // Ters Dönüşüm
        }
    }
}
