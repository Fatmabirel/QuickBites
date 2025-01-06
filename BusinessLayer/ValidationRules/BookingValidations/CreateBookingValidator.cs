using DtoLayer.BookingDto;
using FluentValidation;

namespace BusinessLayer.ValidationRules.BookingValidations
{
    public class CreateBookingValidator : AbstractValidator<CreateBookingDto>
    {
        public CreateBookingValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez!");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon alanı boş geçilemez!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Email alanı boş geçilemez!");
            RuleFor(x => x.PersonCount).NotEmpty().WithMessage("Kişi sayısı boş geçilemez!");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Tarih alanı boş geçilemez!");


            RuleFor(x => x.Name).MinimumLength(5).MaximumLength(50).WithMessage("İsim alanı 5 ile 50 karakter arasında olmalıdır!");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("Açıklama alanı en fazla 500 karakter olmalıdır!");

            RuleFor(x => x.Mail).EmailAddress().WithMessage("Lütfen geçerli bir email adresi giriniz!");
        }
    }
}
