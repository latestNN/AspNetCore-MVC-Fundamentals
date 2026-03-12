using System.ComponentModel.DataAnnotations;

namespace P05._02_Validationları_Baska_Sinifta_Tutma_ModelMetaDataType.Models.ModelMetadataTypes
{
    public class ProductMetadata
    {
        [Required(ErrorMessage = "Lütfen Name alanını boş bırakmayınız.")]
        [StringLength(100, ErrorMessage = "Lütfen name'i en fazla 100 karakter giriniz.")]
        public string Name { get; set; }



        [EmailAddress(ErrorMessage = "Lütfen doğru bir email adresi giriniz.")]
        public string Email { get; set; }
    }
}
