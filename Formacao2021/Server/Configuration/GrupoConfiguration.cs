using Formacao2021.Shared.Models.Tabelas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Formacao2021.Server.Configuration
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.HasData(
                new Grupo
                {
                    ID = new Guid("f6df5993-d2ba-4d8b-9bcb-ac4f1b7fb624"),
                    Nome = "portway"
                },
                new Grupo
                {
                    ID = new Guid("fd47ee52-979e-4381-b1be-93288de25af0"),
                    Nome = "EXTERNO"
                }
            );
        }
    }
}
