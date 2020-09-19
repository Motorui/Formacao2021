using Microsoft.AspNetCore.Identity;

namespace Formacao2021.Server.Models.Identity
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
