using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BL.Interfaces
{
    public interface IServicios
    {
        List<DATOS.Servicios> listarServicios();
        void insertarServicio(DATOS.Servicios servicio);
    }
}
