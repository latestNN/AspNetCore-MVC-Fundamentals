using FluentValidation;

namespace P05._03_Fluent_Validation.Models.Validators
{
    public class ProductValidatior : AbstractValidator<Product>
    {
        public ProductValidatior()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("Email boş olamaz!"); 
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen doğru bir email giriniz!");

            RuleFor(x => x.Name).NotNull().WithMessage("Lütfen Prodcut Name'i Null geçmeyiniz!").NotEmpty().WithMessage("Lütfen Prodcut Name'i Boş geçmeyiniz!");
            RuleFor(x => x.Name).NotNull().MaximumLength(100).WithMessage("Lütfen product Name'i maximum 100 karakter giriniz!");
        }
    }
}
