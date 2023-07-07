using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoForElmaAndValidation.Models
{
    public class Employees
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [RegularExpression(@"^(?![\W_]+$)(?!\d+$)[a-zA-Z0-9 .&',_-]+$", ErrorMessage = "Use letters only please")]
        [StringLength(50, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^(?![\W_]+$)(?!\d+$)[a-zA-Z0-9 .&',_-]+$", ErrorMessage = "Use letters only please")]
        [StringLength(50, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string JobTitle { get; set; }
    }
}