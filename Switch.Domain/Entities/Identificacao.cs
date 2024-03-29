﻿using Switch.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    public class Identificacao
    {
        public int Id { get; set; }

         public TipoDocumento TipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public Guid UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
