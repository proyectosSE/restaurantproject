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
    public partial class mantsalas : Form
    {
        public mantsalas()
        {
            InitializeComponent();
            fechasala.Format = DateTimePickerFormat.Short;
            buttEdit.Visible = false;
            cargardatos();
        }
        string mvar;
        private void btagregar_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = "'" + txtsalas.Text + "','" + fechasala.Text + "','" + txtestado.Text + "'";
            string tabla = "salas";
            cls.Agregar(datos, tabla);
            cargardatos();
            limpiar.LimpiarTextBoxes(this);
        }
        private void cargardatos()
        {
            String consulta = "SELECT * FROM salas";
            
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
                        if (dataGridView1.Columns.Contains("id_sala")) dataGridView1.Columns["id_sala"].DisplayIndex = 0;
                        if (dataGridView1.Columns.Contains("nomsala")) dataGridView1.Columns["nomsala"].DisplayIndex = 1;
                        if (dataGridView1.Columns.Contains("fecha")) dataGridView1.Columns["fecha"].DisplayIndex = 2;
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
            string up = "nomsala ='" + txtsalas.Text + "', fecha = "+"'"+fechasala.Text +"', estado= '"+txtestado.Text+"'";
            string tbl = "salas";
            string id = "id_sala = '" + mvar + "'";
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
            txtsalas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fechasala.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtestado.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            buttEdit.Visible = true;
            btagregar.Visible = false;
        }
                
    }
}
