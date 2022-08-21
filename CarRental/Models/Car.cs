using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Models
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        [Display(Name = "Model")]
        public string CarModel { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        [Display(Name = "Brand")]
        public string CarBrand { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        [Display(Name = "Plate Num")]
        public string CarPlateNum { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,2)")]
        [DataType(DataType.Currency)]
        [Display(Name = "Price Day")]
        public decimal CarPriceDay { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,2)")]
        [DataType(DataType.Currency)]
        [Display(Name = "Price Week")]
        public decimal CarPriceWeek { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,2)")]
        [DataType(DataType.Currency)]
        [Display(Name = "Price Month")]
        public decimal CarPriceMonth { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        [Display(Name = "Avilable")]
        public string CarAvilable { get; set; }
    }
}
