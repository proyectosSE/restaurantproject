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

namespace ProyectoRestaurante
{
    public partial class mantdepar : Form
    {
        public mantdepar()
        {
            InitializeComponent();
            buttEdit.Visible = false;
            cargardatos();
        }

        private string mivar;
        private void btagregar_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = "'" + txtdepart.Text + "'," + txtprovincia.Text + ", '" + txtest.Text + "'";
            string tabla = "departamentos";
            cls.Agregar(datos, tabla);
            cargardatos();
        }
        
        private void cargardatos()
        {
            String consulta = "SELECT * FROM departamentos";
            
            try
            {
                using (SqlConnection conexion = new SqlConnection(rutadb.conexion))
                {
                    conexion.Open();
                    
                    using (SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;

                        // Configuración de columnas
                        if (dataGridView1.Columns.Contains("id_departamento")) dataGridView1.Columns["id_departamento"].DisplayIndex = 0;
                        if (dataGridView1.Columns.Contains("departamento")) dataGridView1.Columns["departamento"].DisplayIndex = 1;
                        if (dataGridView1.Columns.Contains("id_provincia")) dataGridView1.Columns["id_provincia"].DisplayIndex = 2;
                        if (dataGridView1.Columns.Contains("estado")) dataGridView1.Columns["estado"].DisplayIndex = 3;

                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }

        private void buttEdit_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string up = "departamento ='" + txtdepart.Text + "', id_provincia = "+ txtprovincia.Text+ ", estado= '"+txtest.Text+"'";
            string tbl = "departamentos";
            string id = "id_departamento = '" + mvar + "'";
            cls.Actualizar(up, tbl, id);
            
            buttEdit.Visible = false;
            btagregar.Visible = true;
            cargardatos();
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string mvar;
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mvar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtdepart.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtprovincia.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtest.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            buttEdit.Visible = true;
            btagregar.Visible = false;
        }
                
    }
}
