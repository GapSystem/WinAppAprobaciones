using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WinAppAprobaciones
{
    public partial class Frm_Login : Form
    {

        public Int16 user;
        public Frm_Login()
        {
            InitializeComponent();
            txt_usr.Focus();
        }

        

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Entities.Session.CodUsuario = Convert.ToInt16(Autentificar(txt_usr.Text, txt_pwd.Text));

            if(Entities.Session.CodUsuario > 0)
            {
                Frm_gerenciaAprobaciones frm = new Frm_gerenciaAprobaciones();
                user = Entities.Session.CodUsuario;
                frm.Show();
            }
            else
                MessageBox.Show("Usuario y/o Contraseña incorrecto");
        }

        private static int Autentificar(String user, String pwd)
        {
            int resultado = -1;
            SqlConnection cnn;
            DataTable dt = new DataTable();
            cnn = new SqlConnection(Datos.DbInfo.ConnectionString);
            cnn.Open();
            SqlCommand c = new SqlCommand("select * from seguridadusuario where nomusu = '" + user + "' and claacc = '" + pwd + "'", cnn);
            SqlDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {

                resultado = dr.GetInt32(0);
            }
            cnn.Close();
            return resultado;
        }

        private void txt_usr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                txt_pwd.Focus();
            }
        }

        private void txt_pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Entities.Session.CodUsuario = Convert.ToInt16(Autentificar(txt_usr.Text, txt_pwd.Text));

                if (Entities.Session.CodUsuario > 0)
                {
                    Frm_gerenciaAprobaciones frm = new Frm_gerenciaAprobaciones();
                    frm.Show();
                }
                else
                    MessageBox.Show("Usuario y/o Contraseña incorrecto");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
