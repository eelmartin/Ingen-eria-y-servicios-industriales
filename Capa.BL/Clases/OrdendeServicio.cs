using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.BL.Interfaces;
using Capa.DATOS;

namespace Capa.BL.Clases
{
    public class OrdendeServicio : IOrdendeServicio
    {
        public void insertarOrdendeServicio(DATOS.OrdendeServicio ordendeServicio)
        {
            DS.Interfaces.IOrdendeServicio iordendeServicio = new DS.Clases.OrdendeServicio();
            iordendeServicio.insertarOrdendeServicio(ordendeServicio);
        }

        public List<DATOS.OrdendeServicio> listarOrdendeServicio()
        {
            DS.Interfaces.IOrdendeServicio iordendeServicio = new DS.Clases.OrdendeServicio();
            return iordendeServicio.listarOrdendeServicio();
        }
    }
}
