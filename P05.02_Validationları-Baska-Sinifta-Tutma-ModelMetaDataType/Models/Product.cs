using Microsoft.AspNetCore.Mvc;
using P05._02_Validationları_Baska_Sinifta_Tutma_ModelMetaDataType.Models.ModelMetadataTypes;
using System.ComponentModel.DataAnnotations;

namespace P05._02_Validationları_Baska_Sinifta_Tutma_ModelMetaDataType.Models
{
    [ModelMetadataType(typeof(ProductMetadata))]
    public class Product
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Email { get; set; }
    }
}
