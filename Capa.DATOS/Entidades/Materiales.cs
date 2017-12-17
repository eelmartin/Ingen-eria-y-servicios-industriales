using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DATOS
{
    public class Materiales
    {
        [PrimaryKey]
        [AutoIncrement]
        public int idMaterial { get; set; }
        public int idOrdenCompra { get; set; }
        public int cantidadMat { get; set; }
        public float precioMat { get; set; }
        public string nomMateriales { get; set; }
        public int CantidadMat { get; set; }
        public string Unidad { get; set; }
    }
}
