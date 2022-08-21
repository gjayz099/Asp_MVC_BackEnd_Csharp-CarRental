using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        [Display(Name = "Model")]
        public string BookingCarModel { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        [Display(Name = "FirstName")]
        public string BookingFName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        [Display(Name = "LastName")]
        public string BookingLName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Num")]
        public string  BookingPhoneNum { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Pick Up Date")]
        public DateTime PickUpDate { get; set; }
    }
}
