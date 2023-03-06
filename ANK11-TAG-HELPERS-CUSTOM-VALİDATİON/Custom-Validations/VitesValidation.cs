using System.ComponentModel.DataAnnotations;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Custom_Validations
{
    public class VitesValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {

            int vtsL = value.ToString().Length;

            if (vtsL < 2 || vtsL > 10)
                {
                    return new ValidationResult("Vites istenilen aralıkta değil.");
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
