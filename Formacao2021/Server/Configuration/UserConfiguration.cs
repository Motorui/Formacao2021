using Formacao2021.Server.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Formacao2021.Server.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(
                new AppUser
                {
                    Id = new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f").ToString(),
                    Name = "Rui Pereira",
                    UserName = "RaPereira",
                    NormalizedUserName = "RAPEREIRA",
                    PasswordHash = "AQAAAAEAACcQAAAAEK9oxRxsEji9BpEDLL5EwMNTFo3ZsVhz9hXDT+9sNzP9n1pQhQ55VzY7yt00BKRJeg==",
                    Email = "rui.santos@portway.pt",
                    NormalizedEmail = "RUI.SANTOS@PORTWAY.PT"
                }
            );
        }
    }
}
