using System;
using System.Collections.Generic;

namespace Capa.DATOS.Templates
{
    public class FormatoServicio : IPdfTemplate
    {
        private Dictionary<string, string> _FormData;
        private string _Template = "C:/Users/Ed/Desktop/OrdenServicioF.pdf";

        public FormatoServicio(int numorden , int numproyecto, string nombreprovedor, string rfc, string tel, string correo, string colonia, string calle, string num, string concepto, string unidad, string precio, string total, int totalGeneral)
        {
            _FormData = new Dictionary<string, string>
            {
                { "NUMORDENS", numorden.ToString()},
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
                { "COLUNIDAD", unidad },
                { "COLPRECIO", precio },
                { "COLTOTAL", total },
                { "TOTALSERVICIO", totalGeneral.ToString() }
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
