using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DATOS
{
    public class Proveedor
    {
        [PrimaryKey]
        [AutoIncrement]
        public int idProveedor { get; set; }
        public string nombrePro { get; set; }
        public string rfcPro { get; set; }
        public string coloniaPro { get; set; }
        public string callePro { get; set; }
        public string numeroLocalPro { get; set; }
        public string telefonoPro { get; set; }
        public string correoElecPro { get; set; }
    }
}
