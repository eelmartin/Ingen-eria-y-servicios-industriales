using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.DATOS;
using ServiceStack.OrmLite;

namespace Capa.DS.Clases
{
    public class PrecioMateriales : Interfaces.IPrecioMateriales
    {
        public void insertarPrecioMateriales(DATOS.PrecioMateriales precioMateriales)
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            db.Insert(precioMateriales);
        }

        public List<DATOS.PrecioMateriales> listarPrecioMateriales()
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            List<DATOS.PrecioMateriales> listaPrecioMateriales = db.Select<DATOS.PrecioMateriales>();
            return listaPrecioMateriales;
        }
    }
}
