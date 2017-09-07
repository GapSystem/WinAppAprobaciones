using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppAprobaciones.Entities;

namespace WinAppAprobaciones
{
    public partial class Frm_gerenciaAprobaciones : Form
    {

        public Frm_gerenciaAprobaciones()
        {
            InitializeComponent();
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_gerenciaAprobaciones_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            CargarOrdenes();
        }

        private void CargarOrdenes ()
        {
            SqlConnection cnn;
            //DataTable dt = new DataTable();
            cnn = new SqlConnection(Datos.DbInfo.ConnectionString);
            //cnn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_apruebaDirectores", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@usr",SqlDbType.Int).Value= 2007;
                SqlDataAdapter da = new SqlDataAdapter(cmd);               
                DataTable dt = new DataTable();
                cnn.Open();
                da.Fill(dt);
                dgv_ordenes.DataSource = dt;

                DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
                CheckBox chk = new CheckBox();
                CheckboxColumn.Width = 20;
                CheckboxColumn.Name = "APROBAR";
                dgv_ordenes.Columns.Add(CheckboxColumn);

                dgv_ordenes.Columns[0].Width = 50;
                dgv_ordenes.Columns[1].Width = 100;
                dgv_ordenes.Columns[2].Width = 300;
                dgv_ordenes.Columns[3].Width = 300;
                dgv_ordenes.Columns[4].Width = 80;
                dgv_ordenes.Columns[5].Width = 250;
                dgv_ordenes.Columns[6].Width = 80;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




    }
}
