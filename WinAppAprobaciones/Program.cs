using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinAppAprobaciones
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Datos.DbInfo.ServerName = "DESKTOP-CT7VRS3";
            //DBInfo.ServerInstance = "DAVID";
            Datos.DbInfo.DataBaseNanme = "Sic3000_SENAPRO";
            Datos.DbInfo.User = "sa";
            Datos.DbInfo.Password = "Gapgr2011";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Login());
        }
    }
}
