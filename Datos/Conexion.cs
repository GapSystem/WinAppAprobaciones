using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Datos
{
    public class Conexion
    {
        public SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source = .; Initial Catalog = SIC3000_SENAPRO; User ID = sa; Password = Gapgr2011";
            return cn;
        }
    }
}
