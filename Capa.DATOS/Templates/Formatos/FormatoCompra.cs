using System;
using System.Collections.Generic;

namespace Capa.DATOS.Templates
{
    public class FormatoCompra : IPdfTemplate
    {
        private Dictionary<string, string> _FormData;
        private string _Template = "C:/Users/Ed/Desktop/OrdenCompraF.pdf";

        public FormatoCompra(int numproyecto, string nombreprovedor, string rfc, string tel, string correo, string colonia, string calle, string num, string concepto, string cantidad, string unidad, string precio, string total)
        {
            _FormData = new Dictionary<string, string>
            {
                { "NUMORDENC", String.Format("001")},
                { "NUMPROYECTO", numproyecto.ToString() },
                { "FECHA",String.Format(DateTime.Now.ToShortDateString())},
                { "NOMBREPROVEEDOR", nombreprovedor },
                { "RFC", rfc },
                { "TELEFONO", tel},
                { "CORREO", correo },
                { "COLONIA", colonia},
                { "CALLE",calle },
                { "NUMERO",num },
                { "COLCONCEPTO",concepto },
                { "COLCANTIDAD",cantidad },
                { "COLUNIDAD", unidad },
                { "COLPRECIO", precio },
                { "COLTOTAL", total },
                { "TOTALMATERIALES", String.Format(" $$$") }
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
