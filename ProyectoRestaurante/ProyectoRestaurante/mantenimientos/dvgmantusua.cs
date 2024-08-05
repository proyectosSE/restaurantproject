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

namespace ProyectoRestaurante
{
    public partial class dvgmantusua : Form
    {
        public dvgmantusua()
        {
            InitializeComponent();
            cargadatos();
        }

        private string mivar;

        private void cargadatos()
        {
            string consulta = "SELECT * FROM usuarios";

            try
            {
                using (SqlConnection conexion = new SqlConnection(rutadb.conexion))
                {
                    conexion.Open();

                    using (SqlDataAdapter ad = new SqlDataAdapter(consulta,conexion))
                    {
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        dataGridView.DataSource = dt;

                        if (dataGridView.Columns.Contains("id_usuario")) dataGridView.Columns["id_usuario"].DisplayIndex = 0;
                        if (dataGridView.Columns.Contains("nombres")) dataGridView.Columns["nombres"].DisplayIndex = 1;
                        if(dataGridView.Columns.Contains("sexo")) dataGridView.Columns["sexo"].DisplayIndex= 2;
                        if (dataGridView.Columns.Contains("direccion")) dataGridView.Columns["direccion"].DisplayIndex = 3;
                        if (dataGridView.Columns.Contains("telefono")) dataGridView.Columns["telefono"].DisplayIndex = 4;
                        if(dataGridView.Columns.Contains("email")) dataGridView.Columns["email"].DisplayIndex = 5;
                        if (dataGridView.Columns.Contains("usuario")) dataGridView.Columns["usuario"].DisplayIndex = 6;
                        if(dataGridView.Columns.Contains("password")) dataGridView.Columns["password"].DisplayIndex = 7;
                        if (dataGridView.Columns.Contains("id_nivel")) dataGridView.Columns["id_nivel"].DisplayIndex = 8;
                        if(dataGridView.Columns.Contains("status")) dataGridView.Columns["status"].DisplayIndex = 9;

                        if (dataGridView.Columns.Contains("editar"))dataGridView.Columns["editar"].DisplayIndex = 10;
                        if (dataGridView.Columns.Contains("eliminar")) dataGridView.Columns["eliminar"].DisplayIndex = 11;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos, " + ex);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "editar")
            {
                mivar = dataGridView.CurrentRow.Cells["id_usuario"].Value.ToString();
                int id = Convert.ToInt32(mivar);
                mantusua mt = new mantusua(id);
                mt.ShowDialog();

            }
            if (dataGridView.Columns[e.ColumnIndex].Name == "eliminar")
            {
                mensaje ms = new mensaje();

                if (ms.ShowDialog() == DialogResult.OK)
                {
                    mivar = dataGridView.CurrentRow.Cells["id_usuario"].Value.ToString();
                    Conectar cls = new Conectar();
                    string tbl = "usuarios";
                    string id = "id_usuario = '" + mivar + "'";
                    cls.eliminar(tbl, id);
                }
            }

        }
    }
}
