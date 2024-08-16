using ProyectoRestaurante.clases;
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
            formatoDGV.FormatearDataGridViews(this);
            
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

                        /*foreach (DataGridViewColumn cl in dataGridView1.Columns)
                        {
                            cl.Width = 126;
                        }*/

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mantcli mantcli = Owner as mantcli;
            mantcli.mvar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            mantcli.txtnom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mantcli.txtapell.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mantcli.txtdirec.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mantcli.txtemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mantcli.txtlimicre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            mantcli.fechain.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            mantcli.estado = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            if (mantcli.estado == "A")
            {
                mantcli.rjToggleButton1.Checked = true;
            }
            else
            {
                mantcli.rjToggleButton1.Checked = false;
            }
            mantcli.bteditar.Visible = true;
            mantcli.buttAgregar.Visible = false;
            this.Close();
        }
        
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            string valorABuscar = txtbuscar.Text;
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
        
    }
}
