using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CrudEmp.Models
{
    public class NewEmpClass
    {
        [Key]
        public int Empid { get; set; }

        [Required(ErrorMessage ="Enter Employee Name")]
        [Display(Name ="Emplyee Name")]
        public string Empname { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Age")]
        [Display(Name = " Age")]
        [Range(20,50)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter Employee Salary")]
        [Display(Name = "Salary")]
        public int Salary { get; set; }
    }
}
