using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa.DATOS
{
    public class Proyecto
    {
        [PrimaryKey]
        [AutoIncrement]
        public int numeroProyecto { get; set; }
        public string  nombreProyecto { get; set; }
        public string descripcion { get; set; }
        public int idCliente { get; set; }
        public string estadoProyecto { get; set; }
        public string tipoProyecto { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
        public float abono { get; set; }
        public float manodeObra { get; set; }


    }
}
