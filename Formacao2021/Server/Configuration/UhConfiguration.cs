using Formacao2021.Shared.Models.Tabelas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Formacao2021.Server.Configuration
{
    public class UhConfiguration : IEntityTypeConfiguration<Uh>
    {
        public void Configure(EntityTypeBuilder<Uh> builder)
        {
            builder.HasData(
                new Uh
                {
                    UhID = new Guid("807aeb52-f2d7-4152-8410-a668604a41d4"),
                    UhNome = "Lisboa",
                    UhIATA = "LIS"
                },
                new Uh
                {
                    UhID = new Guid("7a525467-1367-4ddf-9802-6bc44ae695ac"),
                    UhNome = "Porto",
                    UhIATA = "OPO"
                },
                new Uh
                {
                    UhID = new Guid("7b277149-86d7-4c19-816c-0e97e803f491"),
                    UhNome = "Faro",
                    UhIATA = "FAO"
                },
                new Uh
                {
                    UhID = new Guid("7f6e20bd-7106-4c6f-a23d-dde9b0a1e471"),
                    UhNome = "Funchal",
                    UhIATA = "FNC"
                }
            );
        }
    }
}
