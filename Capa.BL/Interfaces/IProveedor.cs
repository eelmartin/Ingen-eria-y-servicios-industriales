using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BL.Interfaces
{
    public interface IProveedor
    {
        List<DATOS.Proveedor> listarProveerdor();
        void insertarProveedor(DATOS.Proveedor proveedor);
        void modificarProveedor(DATOS.Proveedor proveedor);
        DATOS.Proveedor buscarProveedor(string nombreProveedor);
        void eliminarProveedor(int idProveedor);
    }
}
