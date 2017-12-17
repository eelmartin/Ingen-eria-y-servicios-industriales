using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.BL.Interfaces;
using Capa.DATOS;

namespace Capa.BL.Clases 
{
    public class OrdendeCompra : IOrdendeCompra
    {
        public void insertarOrdendeCompra(DATOS.OrdendeCompra ordendeCompra)
        {
            DS.Interfaces.IOrdendeCompra iordendeCompra = new DS.Clases.OrdendeCompra();
            iordendeCompra.insertarOrdendeCompra(ordendeCompra);
        }

        public List<DATOS.OrdendeCompra> listarOrdendeCompra()
        {
            DS.Interfaces.IOrdendeCompra iordendeCompra = new DS.Clases.OrdendeCompra();
            return iordendeCompra.listarOrdendeCompra();
        }
    }
}
