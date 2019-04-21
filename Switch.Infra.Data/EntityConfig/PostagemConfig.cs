using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.EntityConfig
{
    public class PostagemConfig : IEntityTypeConfiguration<Postagem>
    {
        public void Configure(EntityTypeBuilder<Postagem> model)
        {
            model.HasKey(x => x.PostagemId);
            model.Property(x => x.DataPublicacao).IsRequired();
            model.Property(x => x.Texto).IsRequired().HasMaxLength(300);
            model.Property(x => x.Usuario).IsRequired();

            //relacionamento 1 para muitos do lado do muitos
            model.HasOne(x => x.Usuario).WithMany(x => x.Postagens);
        }
    }

}

