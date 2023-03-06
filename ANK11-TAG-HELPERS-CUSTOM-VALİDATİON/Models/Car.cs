using ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Car_Validations;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Models
{
    public class Car
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        public Brand Brand { get; set; }
        [Display(Name="Araç Modeli")]
        [Required(ErrorMessage = "Araç Modeli cannot be left blank")]
        [StringLength(2, ErrorMessage = "Model Name should be less than or equal to two characters.")]
        public string Model { get; set; }

        [Display(Name ="Araç Yılı")]
        [CarYearValidation]
        public int CarYear { get; set; }
        [StringLength(2,ErrorMessage ="Yakit tipi eksik karakter")]
        [MaxLength(20,ErrorMessage ="Yakıt tıpı fazla karakter girdiniz")]
        public string FuelType { get; set; }
        public Status Statu { get; set; }
        [Range(1,5000,ErrorMessage ="Beygir aralığı istenilen düzeyde değil.")]
        public int MotorPower { get; set; }
        [Range(0,1000000,ErrorMessage ="Km aralığı doğru değil")]
        public int Km { get; set; }
        [Display(Name = "İlan Tarihi")]
        [CarListingDateValidation]
        public DateTime ListingDate { get; set; }
        
        public decimal Price { get; set; }
    }
    public enum Status
    {
        New=0,
        SecondHand,
        Damaged
    }
    public enum Brand
    {
        Bmw= 0,
        Mercedes,
        Tofas,
        Audi,
        Togg,
        Skoda
    }

}
