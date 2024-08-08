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

        private void button1_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = "'"+txtdepart.Text+"',"+txtprovincia.Text+"";
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
                        if (dataGridView1.Columns.Contains("editar")) dataGridView1.Columns["editar"].DisplayIndex = 3;
                        if (dataGridView1.Columns.Contains("eliminar")) dataGridView1.Columns["eliminar"].DisplayIndex = 4;
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
            string up = "departamento ='" + txtdepart.Text + "', id_provincia = "+ txtprovincia.Text+ "";
            string tbl = "departamentos";
            string id = "id_departamento = '" + mivar + "'";
            cls.Actualizar(up, tbl, id);
            
            buttEdit.Visible = false;
            button1.Visible = true;
            cargardatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                txtdepart.Text = dataGridView1.CurrentRow.Cells["departamento"].Value.ToString();
                txtprovincia.Text = dataGridView1.CurrentRow.Cells["id_provincia"].Value.ToString();
                mivar = dataGridView1.CurrentRow.Cells["id_departamento"].Value.ToString();
                buttEdit.Visible = true;
                button1.Visible = false;

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                mensaje ms = new mensaje();

                if (ms.ShowDialog() == DialogResult.OK)
                {
                    mivar = dataGridView1.CurrentRow.Cells["id_departamento"].Value.ToString();
                    Conectar cls = new Conectar();
                    string tbl = "departamentos";
                    string id = "id_departamento = '" + mivar + "'";
                    cls.eliminar(tbl, id);
                    cargardatos();
                }
            }
        }
    }
}
