using System;
using System.Collections.Generic;

namespace Switch.Domain.Entities
{
    public class Postagem
    {
        public Guid PostagemId { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Texto { get; set; }

        public Guid UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }      
       
    }
}
