using Capa.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.DATOS;

namespace Capa.BL.Clases
{
    public class Proyecto : IProyecto
    {
        public DATOS.Proyecto buscar(int id)
        {
            Capa.DATOS.Proyecto proyecto = null;
            DS.Interfaces.IProyecto iproyecto = new DS.Clases.Proyecto();
            List<DATOS.Proyecto> lista = iproyecto.listarProyecto();
            for (int i = 0; i < lista.Count; i++)
            {
                proyecto = lista[i];
                if (proyecto.numeroProyecto == id)
                {

                }
                else
                {
                    proyecto = null;
                }
            }


            return proyecto;
        }

        public void insertarProyecto(DATOS.Proyecto proyecto)
        {
            DS.Interfaces.IProyecto iproyecto = new DS.Clases.Proyecto();
            iproyecto.insertarProyecto(proyecto);
        }

        public List<DATOS.Proyecto> listarProyecto()
        {
            DS.Interfaces.IProyecto iproyecto = new DS.Clases.Proyecto();
            return iproyecto.listarProyecto();
        }

        public void modificarProyecto(DATOS.Proyecto proyecto)
        {
            DS.Interfaces.IProyecto iproyecto = new DS.Clases.Proyecto();
            iproyecto.modificarProyecto(proyecto);
        }
    }
}
