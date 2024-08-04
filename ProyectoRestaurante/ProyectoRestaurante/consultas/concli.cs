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
    public partial class concli : Form
    {
        public concli()
        {
            InitializeComponent();
            cargardatos();
        }

        private void cargardatos()
        {

            String consulta = "SELECT * FROM clientes";
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
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            string valorABuscar = txtcli.Text;
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
