using Capa.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BL.Clases
{
    public class Proveedor : IProveedor
    {

        public List<DATOS.Proveedor> listarProveerdor()
        {
            DS.Interfaces.IProveedor iProveedor = new DS.Clases.Proveedor();
            return iProveedor.listarProveedor();
        }


        public void insertarProveedor(DATOS.Proveedor proveedor)
        {
            DS.Interfaces.IProveedor iProveedor = new DS.Clases.Proveedor();
            iProveedor.insertarProveedor(proveedor);
        }


        public void modificarProveedor(DATOS.Proveedor proveedor)
        {
            DS.Interfaces.IProveedor iProveedor = new DS.Clases.Proveedor();
            iProveedor.modificarProveedor(proveedor);
        }


        public void eliminarProveedor(int idProveedor)
        {
            DS.Interfaces.IProveedor iProveedor = new DS.Clases.Proveedor();
            iProveedor.eliminarProveedor(idProveedor);
        }


        public DATOS.Proveedor buscarProveedor(string nombre)
        {
            Capa.DATOS.Proveedor proveedor = null;
            DS.Interfaces.IProveedor iProveedor = new DS.Clases.Proveedor();
            List<DATOS.Proveedor> lista = iProveedor.listarProveedor();
            for (int i = 0; i < lista.Count; i++)
            {
                proveedor = lista[i];
                if (proveedor.nombrePro.CompareTo(nombre)==0)
                {
                    break;
                }
                else
                {
                    proveedor = null;
                }
            }


            return proveedor;
        }
    }
}
