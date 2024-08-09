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
                        if(dataGridView1.Columns.Contains("estado")) dataGridView1.Columns["estado"].DisplayIndex= 7;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mantcli mantcli = Owner as mantcli;
            mivar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            mantcli.mvar = mivar;
            mantcli.txtnom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mantcli.txtapell.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mantcli.txtdirec.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mantcli.txtemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mantcli.txtlimicre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            mantcli.fechain.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            mantcli.txtest.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            mantcli.bteditar.Visible = true;
            mantcli.buttAgregar.Visible = false;
            this.Close();

        }
    }
}
