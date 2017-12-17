using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.DATOS;
using ServiceStack.OrmLite;

namespace Capa.DS.Clases
{
    public class Cliente : Interfaces.ICliente
    {
        

        public void insertarCliente(DATOS.Cliente cliente)
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            db.Insert(cliente);
        }

        public List<DATOS.Cliente> listarCliente()
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            List<DATOS.Cliente> listaCliente = db.Select<DATOS.Cliente>();
            return listaCliente;
        }

        public void modificarCliente(DATOS.Cliente cliente)
        {
            var conexion = Conexion.establecerConexion();
            var db = conexion.Open();
            db.Update(cliente);
        }
    }
}
