using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        [Display(Name = "FirstName")]
        public string EmployeeFName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        [Display(Name = "LastName")]
        public string EmployeeLName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Num")]
        public string EmployeePhoneNum { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,2)")]
        [DataType(DataType.Currency)]
        [Display(Name = "Salary")]
        public decimal EmployeeSalary { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Join Date")]
        public DateTime JoinDate { get; set; }
    }
}
