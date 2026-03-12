using System.ComponentModel.DataAnnotations;

namespace P05._01_Validation.Models
{
    public class Product
    {
        public int Id { get; set; }


        [Required(ErrorMessage ="Lütfen Name alanını boş bırakmayınız.")]
        [StringLength(100, ErrorMessage ="Lütfen name'i en fazla 100 karakter giriniz.")]
        public string Name { get; set; }


        public int Quantity { get; set; }



        [EmailAddress(ErrorMessage ="Lütfen doğru bir email adresi giriniz.")]

        public string Email { get; set; }
    }
}
