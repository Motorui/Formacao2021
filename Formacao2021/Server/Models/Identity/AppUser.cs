using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Formacao2021.Server.Models.Identity
{
    public class AppUser : IdentityUser
    {
        public AppUser() : base() { }

        [PersonalData]
        [Required(ErrorMessage = "O campo {0} é obrigatório"), Display(Name = "Nome")]
        [StringLength(50, ErrorMessage = "O campo {0} deve de conter entre {2} e {1} caracteres.", MinimumLength = 3)]
        public string Name { get; set; }
        public ICollection<AppUserRole> AppUserRoles { get; set; }
        public ICollection<UserUh> UserUhs { get; set; }

    }
}
