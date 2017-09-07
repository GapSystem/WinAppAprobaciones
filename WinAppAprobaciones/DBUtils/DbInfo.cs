using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    class DbInfo
    {
        private static string serverName;
        private static string serverInstance;
        private static string user;
        private static string dataBase;
        private static string password;

        public static string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }

        public static string ServerInstance
        {
            get { return serverInstance; }
            set { serverInstance = value; }
        }

        public static string User
        {
            get { return user; }
            set { user = value; }
        }

        public static string DataBaseNanme
        {
            get { return dataBase; }
            set { dataBase = value; }
        }

        public static string Password
        {
            get { return password; }
            set { password = value; }
        }

        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(serverInstance))
                    return string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", serverName, dataBase, user, password);
                else
                    return string.Format("Data Source={0}\\{1};Initial Catalog={2};User ID={3};Password={4}", serverName, serverInstance, dataBase, user, password);
            }
        }

        public static object GetIdentity(SqlCommand command)
        {
            try
            {
                command.CommandText = "SELECT @@IDENTITY";
                var identity = command.ExecuteScalar();
                return identity;
            }
            catch (Exception ex)
            {
                throw new Exception("Identity could not been retrieved", ex);
            }
        }
    }
}
