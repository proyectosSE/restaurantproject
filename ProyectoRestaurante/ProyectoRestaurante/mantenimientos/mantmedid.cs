using ProyectoRestaurante.clases;
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
    public partial class mantmedid : Form
    {
        public mantmedid()
        {
            InitializeComponent();
            buttEdit.Visible = false;
            cargardatos();
        }

        string mvar;
        private void btagregar_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = "'" + txtmedida.Text + "', '" + txtest.Text + "'";
            string tabla = "medidas";
            cls.Agregar(datos, tabla);
            cargardatos();
            limpiar.LimpiarTextBoxes(this);
        }

        private void cargardatos()
        {
            String consulta = "SELECT * FROM medidas";
            
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
                        if (dataGridView1.Columns.Contains("id_medida")) dataGridView1.Columns["id_medida"].DisplayIndex = 0;
                        if (dataGridView1.Columns.Contains("descripcion")) dataGridView1.Columns["descripcion"].DisplayIndex = 1;
                        if (dataGridView1.Columns.Contains("estado")) dataGridView1.Columns["estado"].DisplayIndex = 2;
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
            string up = "descripcion ='"+txtmedida.Text+"', estado= '" + txtest.Text + "'";
            string tbl = "medidas";
            string id = "id_medida='"+mvar+"'";
            cls.Actualizar(up, tbl, id);

            buttEdit.Visible = false;
            cargardatos();
            btagregar.Visible = true;
            limpiar.LimpiarTextBoxes(this);
            
        }


        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mvar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtmedida.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtest.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            buttEdit.Visible = true;
            btagregar.Visible = false;
        }

    }
}
