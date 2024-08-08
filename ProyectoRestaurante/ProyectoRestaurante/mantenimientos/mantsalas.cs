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
        private string mivar;
        private void button1_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = "'"+txtsalas.Text+"','"+fechasala.Text+"','"+txtestado.Text+"'";
            string tabla = "salas";
            cls.Agregar(datos, tabla);
            cargardatos();
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
            string up = "nomsala ='" + txtsalas.Text + "', fecha = "+"'"+fechasala.Text +"'";
            string tbl = "salas";
            string id = "id_sala = '" + mivar + "'";
            cls.Actualizar(up, tbl, id);

            buttEdit.Visible = false;
            cargardatos();
            button1.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                txtsalas.Text = dataGridView1.CurrentRow.Cells["nomsala"].Value.ToString();
                fechasala.Text = dataGridView1.CurrentRow.Cells["fecha"].Value.ToString();
                mivar = dataGridView1.CurrentRow.Cells["id_sala"].Value.ToString();
                buttEdit.Visible = true;
                button1.Visible = false;

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                mensaje ms = new mensaje();

                if (ms.ShowDialog() == DialogResult.OK)
                {
                    mivar = dataGridView1.CurrentRow.Cells["id_sala"].Value.ToString();
                    Conectar cls = new Conectar();
                    string tbl = "salas";
                    string id = "id_sala = '" + mivar + "'";
                    cls.eliminar(tbl, id);
                    cargardatos();
                }
            }
        }
    }
}
