using Capa.DATOS.Templates;
using iText.Forms;
using iText.Kernel.Pdf;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Capa.BL.Helpers
{
    public class PdfHandler
    {
        public static bool CrearPDF(IPdfTemplate template, string pathSalida)
        {
            return LlenarForm(template.GetForm(), template.GetTemplate(), pathSalida);
        }
        private static bool LlenarForm(Dictionary<string, string> data, string pathEntrada, string pathSalida)
        {
            try
            {
                using (PdfDocument p = new PdfDocument(new PdfReader(pathEntrada), new PdfWriter(pathSalida)))
                {
                    PdfAcroForm form = PdfAcroForm.GetAcroForm(p, true);
                    foreach (string key in data.Keys)
                    {
                        data.TryGetValue(key, out string value);
                        var field = form.GetField(key);
                        field.SetValue(value);
                    }
                    form.FlattenFields();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}