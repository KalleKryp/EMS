using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EMS.Utilities;


namespace EMS.Models.ViewModels
{
    public class EmployeesCreateVM
    {

        [Display(Name = "Employee Name")]
        [Required(ErrorMessage = "Must enter a name.")]
        public string Name { get; set; }

        [Display(Name = "E-mail Address")]
        [Validation("@acme.com")]
        [EmailAddress]
        [Required(ErrorMessage = "Must enter an e-mail.")]
        public string Email { get; set; }

        [Display(Name = "What is 2 +2?")]
        [Required(ErrorMessage = "Answer required.")]
        [Range(4, 4)]
        public int BotCheck { get; set; }
    }
}
