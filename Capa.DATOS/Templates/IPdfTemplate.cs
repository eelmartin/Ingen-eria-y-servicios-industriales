using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DATOS.Templates
{
    public interface IPdfTemplate
    {
        Dictionary<string, string> GetForm();
        string GetTemplate();
    }
}
