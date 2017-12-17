using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DATOS
{
    public class OrdendeServicio
    {
        [PrimaryKey]
        [AutoIncrement]
        public int idOrdendeServicio { get; set; }
        public int IdProveedor { get; set; }
        public int NumProyecto { get; set; }
        public float totalS { get; set; }
    }
}
