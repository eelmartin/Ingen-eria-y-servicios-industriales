using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;

namespace Capa.DS
{
    public class Conexion
    {
        public static OrmLiteConnectionFactory establecerConexion()
        {
            return new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
        }
    }
}
