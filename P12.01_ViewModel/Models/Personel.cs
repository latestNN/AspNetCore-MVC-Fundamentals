using P12._01_ViewModel.ViewModels;

namespace P12._01_ViewModel.Models
{
    public class Personel // Entity Model
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public int Salaray { get; set; }

        #region Implicit Dönüşüm
        public static implicit operator PersonelCreateViewModel(Personel model)
        {
            return new PersonelCreateViewModel
            {
                Name = model.Name,
                LastName = model.LastName
            };
        } 



        //Tam Tersi Dönüşüm
        public static implicit operator Personel(PersonelCreateViewModel model)
        {
            return new Personel
            {
                Name = model.Name,
                LastName = model.LastName
            };
        }
        #endregion

        #region Explicit Dönüşüm
        public static explicit operator PersonelCreateViewModel(Personel model)
        {
            return new PersonelCreateViewModel
            {
                Name = model.Name,
                LastName = model.LastName
            };
        }



        //Tam Tersi Dönüşüm
        public static explicit operator Personel(PersonelCreateViewModel model)
        {
            return new Personel
            {
                Name = model.Name,
                LastName = model.LastName
            };
        }
        #endregion

    }
}
