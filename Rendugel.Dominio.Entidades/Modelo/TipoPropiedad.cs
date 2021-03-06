﻿using System;
using System.Collections.Generic;

namespace Rendugel.Dominio.Entidades.Modelo
{
    public partial class TipoPropiedad
    {
        public TipoPropiedad()
        {
            LocalIged = new HashSet<LocalIged>();
        }

        public int IdTipoPropiedad { get; set; }
        public int? CodTipoPropiedad { get; set; }
        public string DescTipoPropiedad { get; set; }
        public bool? EsActivo { get; set; }
        public bool? EsBorrado { get; set; }

        public virtual ICollection<LocalIged> LocalIged { get; set; }
    }
}
