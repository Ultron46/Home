using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevOps.UI.Models
{
    public class User
    {

        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }

        [Required]
        [RegularExpression(@"^[1-9]{1}[0-9]{9}$", ErrorMessage ="Phone number is not in valid form")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Email Is not Valid")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and ConfirmPassword is not Match")]
        public string Cpassword { get; set; }

        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateOfBirth { get; set; }

        public Nullable<int> OrganisationId { get; set; }
        public Nullable<byte> RoleId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public System.DateTime RegistrationDate { get; set; }
    }
}