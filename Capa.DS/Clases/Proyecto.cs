using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.DATOS;
using ServiceStack.OrmLite;

namespace Capa.DS.Clases
{
    public class Proyecto : Interfaces.IProyecto
    {
        public void insertarProyecto(DATOS.Proyecto proyecto)
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            db.Insert(proyecto);
        }

        public List<DATOS.Proyecto> listarProyecto()
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            List<DATOS.Proyecto> listaProyecto = db.Select<DATOS.Proyecto>();
            return listaProyecto;
        }

        public void modificarProyecto(DATOS.Proyecto proyecto)
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            db.Update(proyecto);
        }
    }
}
