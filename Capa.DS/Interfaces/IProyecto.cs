using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DS.Interfaces
{
    public interface IProyecto
    {
        List<DATOS.Proyecto> listarProyecto();
        void insertarProyecto(DATOS.Proyecto proyecto);
        void modificarProyecto(DATOS.Proyecto proyecto);
    }
}
