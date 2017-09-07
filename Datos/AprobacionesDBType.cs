using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    class AprobacionesDBType
    {
        private static SqlParameter innerParam;

        /// <summary>
        /// Devuelve un objeto de tipo SqlParameter (usado para cadenas y fechas)
        /// </summary>
        /// <param name="name">Nombre del parametro</param>
        /// <param name="type">Tipo de dato (debe coincidir con el tipo de dato esperado en el sp)</param>
        /// <param name="size">Longitud</param>
        /// <param name="value">Valor</param>
        /// <returns></returns>
        public static SqlParameter GetParameter(string name, SqlDbType type, int size, object value)
        {
            innerParam = new SqlParameter(name, type);
            innerParam.Direction = System.Data.ParameterDirection.Input;
            innerParam.Size = size;
            innerParam.Value = value;
            return innerParam;
        }

        /// <summary>
        /// Devuelve un objeto de tipo SqlParameter (usado para numeros)
        /// </summary>
        /// <param name="name">Nombre del parametro</param>
        /// <param name="type">Tipo de dato (debe coincidir con el tipo de dato esperado en el sp)</param>
        /// <param name="value">Valor</param>
        /// <returns></returns>
        public static SqlParameter GetParameter(string name, SqlDbType type, object value)
        {
            innerParam = new SqlParameter(name, type);
            innerParam.Direction = System.Data.ParameterDirection.Input;
            if (type == SqlDbType.Int)
            {
                innerParam.Value = Convert.ToInt32(value);
            }
            else
            {
                innerParam.Value = value;
            }

            return innerParam;
        }

        public static string getParameterList(SqlCommand cmd)
        {
            StringBuilder sb = new StringBuilder();

            foreach (SqlParameter par in cmd.Parameters)
            {
                sb.AppendFormat("{0} = {1}, ", par.ParameterName, par.Value);
            }

            return sb.ToString();
        }
    }
}
