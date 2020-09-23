using System;
using System.ComponentModel.DataAnnotations;

namespace Formacao2021.Shared.Models.Identity
{
    public class RegisterUser
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "As passwords não são iguais!")]
        public string PasswordConfirm { get; set; }

    }
}
