using System.ComponentModel.DataAnnotations;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Custom_Validations
{
    public class JoinDateValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            
          
            if (Convert.ToDateTime(value) > DateTime.Now)
            {
                return new ValidationResult("Bugunden buyuk olmaz");
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
