using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DS.Interfaces
{
    public interface IProveedor
    {
        List<DATOS.Proveedor> listarProveedor();
        void insertarProveedor(DATOS.Proveedor proveedor);
        void modificarProveedor(DATOS.Proveedor proveedor);
        void eliminarProveedor(int idProveedor);
    }
}
