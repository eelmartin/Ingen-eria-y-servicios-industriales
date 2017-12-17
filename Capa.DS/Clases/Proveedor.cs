using Capa.DS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;

namespace Capa.DS.Clases
{
    public class Proveedor : IProveedor

    {
        public List<DATOS.Proveedor> listarProveedor()
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            List<DATOS.Proveedor> listaProveedor = db.Select<DATOS.Proveedor>();
            return listaProveedor;
        }


        public void modificarProveedor(DATOS.Proveedor proveedor)
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            db.Update(proveedor);
        }


        public void insertarProveedor(DATOS.Proveedor proveedor)
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            db.Insert(proveedor);
        }


        public void eliminarProveedor(int idProveedor)
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            db.Delete<DATOS.Proveedor>(x => x.idProveedor == idProveedor);
        }
    }
}
