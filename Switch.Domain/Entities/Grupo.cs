using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    public class Grupo
    {
        public Guid GrupoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string UrlFoto { get; set; }
    }
}
