using System.ComponentModel.DataAnnotations;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Car_Validations
{
    public class CarPriceValidation: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            decimal fyt = Convert.ToInt32(value);

            if (fyt< 0 || fyt> 2147483647000)
            {
                return new ValidationResult("Lütfen doğru fiyat aralığı giriniz.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
        public override bool IsValid(object? value) //iki farklı kullanımı mevcut. Aradaki farkları araştırın.
        {
            return base.IsValid(value);
        }
    }
}
