using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.DATOS;
using ServiceStack.OrmLite;

namespace Capa.DS.Clases
{
    public class OrdendeCompra : Interfaces.IOrdendeCompra
    {
        public void insertarOrdendeCompra(DATOS.OrdendeCompra ordendeCompra)
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            db.Insert(ordendeCompra);
        }

        public List<DATOS.OrdendeCompra> listarOrdendeCompra()
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            List<DATOS.OrdendeCompra> listaOrdendeCompra = db.Select<DATOS.OrdendeCompra>();
            return listaOrdendeCompra;
        }
    }
}
