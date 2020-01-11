﻿using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Views.Accounts
{
    public class SignupModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage = "Password must be at least six characters long")]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and it's confirmation do not match")]
        public string ConfirmPassword { get; set; }
    }
}
