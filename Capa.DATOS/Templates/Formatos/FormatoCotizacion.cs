using System;
using System.Collections.Generic;

namespace Capa.DATOS.Templates
{
    public class FormatoCotizacion : IPdfTemplate
    {
        private Dictionary<string, string> _FormData;
        private string _Template = "C:/Users/Ed/Desktop/formatoCotizacionF.pdf";

        public FormatoCotizacion(string nombrecliente, string rfc, string tel, string correo, string colonia, string calle, string num, string descripcion,  string concepto, string cantidad, string precio, string total, int totalGeneral)
        {
            _FormData = new Dictionary<string, string>
            {
                { "FECHA",String.Format(DateTime.Now.ToShortDateString())},
                { "NOMBRECLIENTE", nombrecliente },
                { "RFC", rfc },
                { "TELEFONO", tel},
                { "CORREO", correo },
                { "COLONIA", colonia},
                { "CALLE",calle },
                { "NUMERO",num },
                { "DESCRIPCION", descripcion },
                { "COLCONCEPTO",concepto },
                { "COLCANTIDAD",cantidad },
                { "COLPRECIO", precio },
                { "COLTOTAL", total },
                { "TOTALCOTIZACION", totalGeneral.ToString() }
            };



        }

        public Dictionary<string, string> GetForm()
        {
            return _FormData;
        }

        public string GetTemplate()
        {
            return _Template;
        }
    }
}
