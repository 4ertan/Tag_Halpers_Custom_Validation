using System.ComponentModel.DataAnnotations;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Car_Validations
{
    public class CarYearValidation: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {


            if (Convert.ToInt16(value) > DateTime.Now.Year)
            {
                return new ValidationResult("İleri bir yıl girdiniz.");
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
