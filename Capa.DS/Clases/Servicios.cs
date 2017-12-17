using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.DATOS;
using ServiceStack.OrmLite;

namespace Capa.DS.Clases
{
    public class Servicios : Interfaces.IServicios
    {
        public void insertarServicio(DATOS.Servicios servicio)
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            db.Insert(servicio);
        }

        public List<DATOS.Servicios> listarServicios()
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            List<DATOS.Servicios> listaServicio = db.Select<DATOS.Servicios>();
            return listaServicio;
        }
    }
}
