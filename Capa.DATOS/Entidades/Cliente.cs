using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Capa.DATOS
{
    public class Cliente
    {
        [PrimaryKey]
        [AutoIncrement]
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }
        public string coloniaCliente { get; set; }
        public string calleCliente { get; set; }
        public string numeroLocalCliente { get; set; }
        public string telefonoCliente { get; set; }
        public string correoElectronicoCliente { get; set; }
        public string rfcCliente { get; set; }
    }
}
