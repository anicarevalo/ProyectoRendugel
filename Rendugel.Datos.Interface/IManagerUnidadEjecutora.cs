﻿using Rendugel.Dominio.Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendugel.Datos.Interface
{
    public interface IManagerUnidadEjecutora
    {
        int saveManagerUnidadEjecutora(UnidadEjecutora unidadEjecutora);
        void updateManagerUnidadEjecutora(UnidadEjecutora unidadEjecutora);
        UnidadEjecutora ObtenerManagerUnidadEjecutoraPorId(int codTipoPersonal);
    }
}
