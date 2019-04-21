using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.EntityConfig
{
    public class GrupoConfig : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> model)
        {
            model.HasKey(x => x.GrupoId);
            model.Property(x => x.Nome).IsRequired().HasMaxLength(40);
        }
    }
}
