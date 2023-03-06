using System.ComponentModel.DataAnnotations;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Custom_Validations
{
    public class CarTelValidation:ValidationAttribute   
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value!=null && value.ToString().Length==11)
            {

                return ValidationResult.Success;

            }
            return new ValidationResult("Lütfen Telefon numarınızı doğru bicimde giriniz.");
        }
        public override bool IsValid(object? value)
        {
            return base.IsValid(value); 
        }
    }
}
