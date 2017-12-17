using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DATOS
{
    public class OrdendeCompra
    {
        [PrimaryKey]
        [AutoIncrement]
        public int idOrdendeCompra { get; set; }
        public int idProveedor { get; set; }
        public int NumProyecto { get; set; }
        public float totalC { get; set; }
    }
}
