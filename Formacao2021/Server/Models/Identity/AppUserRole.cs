using Microsoft.AspNetCore.Identity;

namespace Formacao2021.Server.Models.Identity
{
    public class AppUserRole : IdentityUserRole<string>
    {
        public AppUserRole() : base() { }
        public virtual AppUser User { get; set; }
        public virtual AppRole Role { get; set; }
    }
}
