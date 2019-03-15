using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreMVCCRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Full Name")]
        [Column(TypeName = "nvarchar(250)")]
        public string FullName { get; set; }

        [Display(Name = "Code")]
        [Column(TypeName = "varchar(10)")]
        public string Code { get; set; }

        [Display(Name = "Position")]
        [Column(TypeName = "varchar(100)")]
        public string Position { get; set; }

        [Display(Name = "OfficeLocation")]
        [Column(TypeName = "varchar(100)")]
        public string OfficeLocation { get; set; }
    }
}
