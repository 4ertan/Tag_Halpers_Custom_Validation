using System.ComponentModel.DataAnnotations;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Car_Validations
{
    public class CarListingDateValidation: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {


            if (Convert.ToDateTime(value) > DateTime.Now)
            {
                return new ValidationResult("İleri bir tarih girdiniz");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
        public override bool IsValid(object? value) 
        {
            return base.IsValid(value);
        }
    }
}
