﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DS.Interfaces
{
    public interface IMateriales
    {
        List<DATOS.Materiales> listarMateriales();
        void insertarMaterial(DATOS.Materiales material);
    }
}
