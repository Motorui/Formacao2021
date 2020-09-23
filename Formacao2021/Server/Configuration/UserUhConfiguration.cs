using Formacao2021.Server.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Formacao2021.Server.Configuration
{
    public class UserUhConfiguration : IEntityTypeConfiguration<UserUh>
    {
        public void Configure(EntityTypeBuilder<UserUh> builder)
        {
            builder.HasData(
                new UserUh
                {
                    UserId = new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"),
                    UhID = new Guid("807aeb52-f2d7-4152-8410-a668604a41d4")
                },
                new UserUh
                {
                    UserId = new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"),
                    UhID = new Guid("7a525467-1367-4ddf-9802-6bc44ae695ac")
                },
                new UserUh
                {
                    UserId = new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"),
                    UhID = new Guid("7b277149-86d7-4c19-816c-0e97e803f491")
                },
                new UserUh
                {
                    UserId = new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"),
                    UhID = new Guid("7f6e20bd-7106-4c6f-a23d-dde9b0a1e471")
                }
            );
        }
    }
}
