using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Formacao2021.Server.Models.Identity
{
    public class AppRole : IdentityRole
    {
        public AppRole() : base() { }

        public AppRole(string roleName) : base(roleName) { }

        public AppRole(string roleName, string description,
            DateTime createdDate)
            : base(roleName)
        {
            base.Name = roleName;

            Description = description;
            CreatedDate = createdDate;
        }

        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<AppUserRole> AppUserRoles { get; set; }
    }
}
