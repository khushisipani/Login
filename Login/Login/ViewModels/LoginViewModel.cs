﻿using System.ComponentModel.DataAnnotations;
namespace Login.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Rememmber Me?")]
        public bool RememberMe { get; set; }
    }
}
