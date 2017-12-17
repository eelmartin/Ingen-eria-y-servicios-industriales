using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DATOS
{
    public class Servicios
    {
        [PrimaryKey]
        [AutoIncrement]
        public int idServicios { get; set; }
        public int idOrdendeServicio { get; set; }
        public float Precio { get; set; }
        public string nomServicio { get; set; }
        public string Unidad { get; set; }
    }
}
