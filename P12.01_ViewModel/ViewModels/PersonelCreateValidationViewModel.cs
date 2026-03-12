using System.ComponentModel.DataAnnotations;

namespace P12._01_ViewModel.ViewModels
{
    public class PersonelCreateValidationViewModel
    {
        [Required]        
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
