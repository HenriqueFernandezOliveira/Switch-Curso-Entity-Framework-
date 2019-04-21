using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using Switch.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.EntityConfig
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> model)
        {

            model.HasKey(x => x.UsuarioId);
            model.Property(x => x.Senha).IsRequired().HasMaxLength(10);
            model.Property(x => x.Nome).IsRequired().HasMaxLength(30);
            model.Property(x => x.Sexo).IsRequired();
            model.Property(x => x.Email).IsRequired();
            model.Property(x => x.StatusRelacionamento).HasDefaultValue(StatusRelacionamento.solteiro);

            //relacionamento 1 para 1
            model.HasOne(x => x.Identificacao).WithOne(x => x.Usuario).HasForeignKey<Identificacao>(x => x.UsuarioId);

            //relacionamento 1 para muitos do lado do 1
            model.HasMany(x => x.Postagens).WithOne(x => x.Usuario).HasForeignKey(x => x.UsuarioId);
        }
    }
}
