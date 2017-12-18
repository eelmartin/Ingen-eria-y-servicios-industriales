using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DS.Interfaces
{
    public interface IPrecioMateriales
    {
        List<DATOS.PrecioMateriales> listarPrecioMateriales();
        void insertarPrecioMateriales(DATOS.PrecioMateriales precioMateriales);
    }
}
