using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.DATOS;
using ServiceStack.OrmLite;

namespace Capa.DS.Clases
{
    public class Materiales : Interfaces.IMateriales
    {
        public void insertarMaterial(DATOS.Materiales material)
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            db.Insert(material);
        }

        public List<DATOS.Materiales> listarMateriales()
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            List<DATOS.Materiales> listaMaterial = db.Select<DATOS.Materiales>();
            return listaMaterial;
        }
    }
}
