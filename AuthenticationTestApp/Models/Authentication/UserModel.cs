using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticationTestApp.Models.Authentication
{
    public class UserModel
    {
        [Required]
        public String Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The Password must be between 6 and 20 characters.")]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not Match.")]
        public String ConfirmPassword { get; set; }
    }
}