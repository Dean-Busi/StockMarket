using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Account
{
    public class RegisterDto
    {
        [Required (ErrorMessage = "Bitte gebe einen Benutzernamen ein.")]
        public string? Username { get; set; }

        [Required (ErrorMessage = "Bitte gebe eine E-Mail Adresse ein.")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required (ErrorMessage = "Bitte gebe ein Passwort ein.")]
        public string? Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Die Passwörter stimmen nicht überein.")]
        public string? ConfirmPassword { get; set; }
    }
}

