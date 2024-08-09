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
            string categoria = "'" + textcat.Text + "','"+txtest.Text+"'";
            string tbcat = "categorias";
            cls.Agregar(categoria,tbcat);
            cargardatos();
        }
        
        private void cargardatos()
        {
           
            String consulta = "SELECT * FROM categorias";
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

                        if (dataGridView1.Columns.Contains("id_categoria")) dataGridView1.Columns["id_categoria"].DisplayIndex = 0;
                        if (dataGridView1.Columns.Contains("descripcion")) dataGridView1.Columns["descripcion"].DisplayIndex = 1;
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
            string up = "descripcion ='"+textcat.Text+"', estado= '"+txtest.Text+"'";
            string tbl = "categorias";
            string id = "id_categoria = '"+mvar+"'";
            cls.Actualizar(up, tbl,id);
            buttAgreg.Visible = true;
            buttEdit.Visible = false;
            cargardatos();
        }

        private void buttBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string mvar;
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mvar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textcat.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtest.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            buttEdit.Visible = true;
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            string valorABuscar = textBuscar.Text;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null &&
                row.Cells[1].Value.ToString().Contains(valorABuscar))
                {
                    dataGridView1.CurrentCell = row.Cells[1];
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
                else if (row.Cells[1].Value == null)
                {
                    MessageBox.Show("Datos no encontrados");
                }
            }
        }
    }
}
