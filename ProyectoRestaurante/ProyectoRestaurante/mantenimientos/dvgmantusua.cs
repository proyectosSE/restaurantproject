using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProyectoRestaurante.clases;

namespace ProyectoRestaurante
{
    public partial class dvgmantusua : Form
    {
        public dvgmantusua()
        {
            InitializeComponent();
            cargadatos();
            formatoDGV.FormatearDataGridViews(this);
        }

        private void cargadatos()
        {
            string consulta = "SELECT * FROM usuarios";

            try
            {
                using (SqlConnection conexion = new SqlConnection(rutadb.conexion))
                {
                    conexion.Open();

                    using (SqlDataAdapter ad = new SqlDataAdapter(consulta,conexion))
                    {
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        dataGridView.DataSource = dt;

                        if (dataGridView.Columns.Contains("id_usuario")) dataGridView.Columns["id_usuario"].DisplayIndex = 0;
                        if (dataGridView.Columns.Contains("nombres")) dataGridView.Columns["nombres"].DisplayIndex = 1;
                        if(dataGridView.Columns.Contains("sexo")) dataGridView.Columns["sexo"].DisplayIndex= 2;
                        if (dataGridView.Columns.Contains("direccion")) dataGridView.Columns["direccion"].DisplayIndex = 3;
                        if (dataGridView.Columns.Contains("telefono")) dataGridView.Columns["telefono"].DisplayIndex = 4;
                        if(dataGridView.Columns.Contains("email")) dataGridView.Columns["email"].DisplayIndex = 5;
                        if (dataGridView.Columns.Contains("usuario")) dataGridView.Columns["usuario"].DisplayIndex = 6;
                        if(dataGridView.Columns.Contains("password")) dataGridView.Columns["password"].DisplayIndex = 7;
                        if (dataGridView.Columns.Contains("id_nivel")) dataGridView.Columns["id_nivel"].DisplayIndex = 8;
                        if(dataGridView.Columns.Contains("status")) dataGridView.Columns["status"].DisplayIndex = 9;

                        if (dataGridView.Columns.Contains("editar"))dataGridView.Columns["editar"].DisplayIndex = 10;
                        if (dataGridView.Columns.Contains("eliminar")) dataGridView.Columns["eliminar"].DisplayIndex = 11;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos, " + ex);
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mantusua ms = Owner as mantusua;
            ms.mvar = dataGridView.CurrentRow.Cells[0].Value.ToString();
            ms.txtnom.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            ms.txtsex.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            ms.txtdirec.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            ms.txttel.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            ms.txtemail.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            ms.txtusua.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            ms.txtpassw.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
            ms.cbbnivel.SelectedValue = dataGridView.CurrentRow.Cells[8].Value.ToString();
            ms.estado = dataGridView.CurrentRow.Cells[9].Value.ToString();
            if (ms.estado == "A")
            {
                ms.rjToggleButton1.Checked = true;
            }
            else
            {
                ms.rjToggleButton1.Checked = false;
            }
            ms.bteditar.Visible = true;
            ms.btagregar.Visible = false;
            this.Close();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            string valorABuscar = txtbuscar.Text;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[1].Value != null &&
                row.Cells[1].Value.ToString().Contains(valorABuscar))
                {
                    dataGridView.CurrentCell = row.Cells[1];
                    dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
                else if (row.Cells[1].Value == null)
                {
                    MessageBox.Show("Datos no encontrados");
                }
            }
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btcerrar_MouseEnter(object sender, EventArgs e)
        {
            btcerrar.BackColor = Color.Gray;
        }

        private void btcerrar_MouseLeave(object sender, EventArgs e)
        {
            btcerrar.BackColor = Color.Black;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView.Columns[e.ColumnIndex].Name == "estado")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {

                        if (e.Value.ToString() == "A")
                        {
                            this.dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            this.dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        }
                    }
                }
            }
        }
        
    }
}
