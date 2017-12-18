using Capa.BL.Interfaces;
using Capa.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BL.Clases
{
    public class PrecioMateriales : IPrecioMateriales
    {
        public void insertarPrecioMateriales(DATOS.PrecioMateriales precioMateriales)
        {
            DS.Interfaces.IPrecioMateriales iprecioMateriales = new DS.Clases.PrecioMateriales();
            iprecioMateriales.insertarPrecioMateriales(precioMateriales);
        }

        public List<DATOS.PrecioMateriales> listarPrecioMateriales()
        {
            DS.Interfaces.IPrecioMateriales iprecioMateriales = new DS.Clases.PrecioMateriales();
            return iprecioMateriales.listarPrecioMateriales();
        }
    }
}
