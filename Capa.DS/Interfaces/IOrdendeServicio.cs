using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DS.Interfaces
{
    public interface IOrdendeServicio
    {
        List<DATOS.OrdendeServicio> listarOrdendeServicio();
        void insertarOrdendeServicio(DATOS.OrdendeServicio ordendeServicio);
    }
}
