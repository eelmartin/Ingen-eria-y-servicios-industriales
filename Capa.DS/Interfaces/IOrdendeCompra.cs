using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DS.Interfaces
{
    public interface IOrdendeCompra
    {
        List<DATOS.OrdendeCompra> listarOrdendeCompra();
        void insertarOrdendeCompra(DATOS.OrdendeCompra ordendeCompra);
    }
}
