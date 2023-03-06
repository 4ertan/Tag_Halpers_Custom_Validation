using System.ComponentModel.DataAnnotations;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Custom_Validations
{
    public class JoinDateValidation:ValidationAttribute
    {

        //bunu siz dolduracaksınız

        //istenilenler => join date bugünden büyük olamaz. 10 yıllık bir şirket olduğunu varsayalım. 11 yıllık çalışan olamaz.
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
        public override bool IsValid(object? value) //iki farklı kullanımı mevcut. Aradaki farkları araştırın.
        {
            return base.IsValid(value);
        }

    }
}
