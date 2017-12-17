using Capa.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.DATOS;

namespace Capa.BL.Clases
{
    public class Materiales : IMateriales
    {
        public void insertarMaterial(DATOS.Materiales material)
        {
            DS.Interfaces.IMateriales imaterial = new DS.Clases.Materiales();
            imaterial.insertarMaterial(material);
        }

        public List<DATOS.Materiales> listarMateriales()
        {
            DS.Interfaces.IMateriales imaterial = new DS.Clases.Materiales();
            return imaterial.listarMateriales();
        }
    }
}
