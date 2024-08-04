using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante
{
    public partial class mantcat : Form
    {
        public mantcat()
        {
            InitializeComponent();
            buttEdit.Visible = false;
            cargardatos();
        }

        private string mivar;
        private void button1_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string categoria ="'"+textcat.Text+"'";
            string tbcat = "categorias";            
            cls.Agregar(categoria,tbcat);
        }

        public static SqlConnection conexion = new SqlConnection("server=ELIASPC;Database=ProyectoRestaurante;Integrated Security=true");
        private void cargardatos()
        {
           
            String consulta = "SELECT * FROM categorias";
            try
            {

                {
                    conexion.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;

                        // Configuración de columnas
                        if (dataGridView1.Columns.Contains("id_categoria")) dataGridView1.Columns["id_categoria"].DisplayIndex = 0;
                        if (dataGridView1.Columns.Contains("descripcion")) dataGridView1.Columns["descripcion"].DisplayIndex = 1;
                        if (dataGridView1.Columns.Contains("editar")) dataGridView1.Columns["editar"].DisplayIndex = 2;
                        if (dataGridView1.Columns.Contains("eliminar")) dataGridView1.Columns["eliminar"].DisplayIndex = 3;
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
            string up = "descripcion ='"+textcat.Text+"'";
            string tbl = "categorias";
            string id = "id_categoria = '"+mivar+"'";
            cls.Actualizar(up, tbl,id);
            InitializeComponent();
            buttEdit.Visible = false;
            cargardatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                textcat.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                mivar = dataGridView1.CurrentRow.Cells["id_categoria"].Value.ToString();
                buttEdit.Visible = true;
                buttAgreg.Visible = false;
                
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                mensaje ms = new mensaje();
                
                if (ms.ShowDialog() == DialogResult.OK)
                {
                    mivar = dataGridView1.CurrentRow.Cells["id_categoria"].Value.ToString();
                    Conectar cls = new Conectar();
                    string tbl = "categorias";
                    string id = "id_categoria = '" + mivar + "'";
                    cls.eliminar(tbl,id);
                }

            }
        }
    }
}
