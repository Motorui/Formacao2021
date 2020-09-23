using Formacao2021.Server.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Formacao2021.Server.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasData(
                new AppUserRole
                {
                    UserId = new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f").ToString(),
                    RoleId = new Guid("e7526d31-3669-4f80-8e85-046e272634b6").ToString()
                }
            );
        }
    }
}
