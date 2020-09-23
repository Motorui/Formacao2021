using System;

namespace Formacao2021.Shared.Models.Identity
{
    public class RegisterUserRole
    {
        public Guid RoleId { get; set; }

        public Guid UserId { get; set; }
    }
}
