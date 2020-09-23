using Formacao2021.Server.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Formacao2021.Server.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                new AppRole
                {
                    Id = new Guid("3b04aa8e-4307-4711-93a4-e2fb2f09f5a5").ToString(),
                    Name = "User",
                    NormalizedName = "USER"
                },
                new AppRole
                {
                    Id = new Guid("e7526d31-3669-4f80-8e85-046e272634b6").ToString(),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            );
        }
    }
}
