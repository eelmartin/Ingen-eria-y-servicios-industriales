using Capa.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.DATOS;

namespace Capa.BL.Clases
{
    public class Servicios : IServicios
    {
        public void insertarServicio(DATOS.Servicios servicio)
        {
            DS.Interfaces.IServicios iservicio = new DS.Clases.Servicios();
            iservicio.insertarServicio(servicio);
        }

        public List<DATOS.Servicios> listarServicios()
        {
            DS.Interfaces.IServicios iservicio = new DS.Clases.Servicios();
            return iservicio.listarServicios();
        }
    }
}
