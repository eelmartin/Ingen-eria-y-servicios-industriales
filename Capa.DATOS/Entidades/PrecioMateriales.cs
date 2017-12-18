using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DATOS
{
    public class PrecioMateriales
    {
        [PrimaryKey]
        [AutoIncrement]
        public int idPrecioMateriales { get; set; }
        public int idOrdendeCompra { get; set; }
        public float precio { get; set; }
        public float cantidad { get; set; }
        public float total { get; set; }
        public int idMateriales { get; set; }
    }
}
