using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.DATOS;
using ServiceStack.OrmLite;

namespace Capa.DS.Clases
{
    public class OrdendeServicio : Interfaces.IOrdendeServicio
    {
        public void insertarOrdendeServicio(DATOS.OrdendeServicio ordendeServicio)
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            db.Insert(ordendeServicio);
        }

        public List<DATOS.OrdendeServicio> listarOrdendeServicio()
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            List<DATOS.OrdendeServicio> listaOrdendeServicio = db.Select<DATOS.OrdendeServicio>();
            return listaOrdendeServicio;
        }
    }
}
