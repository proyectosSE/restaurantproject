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

namespace ProyectoRestaurante.consultas
{
    public partial class conimp : Form
    {
        public conimp()
        {
            InitializeComponent();
            cargardatos(est);
            formatoDGV.FormatearDataGridViews(this);
        }

        private string est = "WHERE estado = 'A'";
        private void cargardatos(string estado)
        {

            String consulta = $"SELECT * FROM impuestos {estado}";
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

                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }

        private void txtimp_TextChanged(object sender, EventArgs e)
        {
            string valorABuscar = txtimp.Text;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null &&
                row.Cells[1].Value.ToString().Contains(valorABuscar))
                {
                    // Encontrar coincidencia, enfocar la fila
                    dataGridView1.CurrentCell = row.Cells[1];
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index; // Opcional: desplaza la fila al visible
                    break;
                }
                else if (row.Cells[1].Value == null)
                {
                    MessageBox.Show("Datos no encontrados");
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "estado")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {

                        if (e.Value.ToString() == "A")
                        {
                            this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        }
                    }
                }
            }
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked)
            {
                est = "WHERE estado = 'I'";
                cargardatos(est);
            }
            else
            {
                est = "WHERE estado = 'A'";
                cargardatos(est);
            }
        }
    }
}
