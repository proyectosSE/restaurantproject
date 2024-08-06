using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante.mantenimientos
{
    public partial class dgvmantcli : Form
    {
        public dgvmantcli()
        {
            InitializeComponent();
            cargardatos();
        }

        

        private string mivar;

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

                        foreach (DataGridViewColumn cl in dataGridView1.Columns)
                        {
                            cl.Width = 126;
                        }

                        if (dataGridView1.Columns.Contains("id_cliente")) dataGridView1.Columns["id_cliente"].DisplayIndex = 0;
                        if (dataGridView1.Columns.Contains("nomcliente")) dataGridView1.Columns["nomcliente"].DisplayIndex = 1;
                        if (dataGridView1.Columns.Contains("apellidocliente")) dataGridView1.Columns["apellidocliente"].DisplayIndex = 2;
                        if (dataGridView1.Columns.Contains("direccliente")) dataGridView1.Columns["direccliente"].DisplayIndex = 3;
                        if (dataGridView1.Columns.Contains("emailcliente")) dataGridView1.Columns["emailcliente"].DisplayIndex = 4;
                        if (dataGridView1.Columns.Contains("limitecredito")) dataGridView1.Columns["limitecredito"].DisplayIndex = 5;
                        if (dataGridView1.Columns.Contains("fechaingreso")) dataGridView1.Columns["fechaingreso"].DisplayIndex = 6;
                        if (dataGridView1.Columns.Contains("editar")) dataGridView1.Columns["editar"].DisplayIndex = 7;
                        if (dataGridView1.Columns.Contains("eliminar")) dataGridView1.Columns["eliminar"].DisplayIndex = 8;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
               mivar = dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString();
               int id = Convert.ToInt32(mivar);
               mantcli mt = new mantcli(id);
               mt.ShowDialog();              
              
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                mensaje ms = new mensaje();

                if (ms.ShowDialog() == DialogResult.OK)
                {
                    mivar = dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString();
                    Conectar cls = new Conectar();
                    string tbl = "clientes";
                    string id = "id_cliente = '" + mivar + "'";
                    cls.eliminar(tbl, id);
                }
            }
        }
    }
}
