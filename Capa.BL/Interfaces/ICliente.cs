using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BL.Interfaces
{
    public interface ICliente
    {
        List<DATOS.Cliente> listarCliente();
        void insertarCliente(DATOS.Cliente cliente);
        void modificarCliente(DATOS.Cliente cliente);
        DATOS.Cliente buscarCliente(string nombreCliente);
        
    }
}
