using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace FormSubmission.Models
{
    public class User

    {   
        [Required(ErrorMessage ="First Name can not be blank.")]
        [MinLength(4, ErrorMessage ="First Name must be at least 4 characters or more.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Last Name can not be blank.")]
        [MinLength(4, ErrorMessage ="Last Name must be at least 4 characters or more.")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Age can not be blank")]
        [Range(0, 500, ErrorMessage = "Please enter a valid age.")]
        public int Age { get; set; }
        [Required (ErrorMessage = "Email address can not be blank.")]
        [EmailAddress]
        public string EmailAddress{ get; set;}
        [Required(ErrorMessage ="Password can not be blank.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}