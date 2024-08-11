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

namespace ProyectoRestaurante.mantenimientos
{
    public partial class mantprov : Form
    {
        public mantprov()
        {
            InitializeComponent();
            fechaingreso.Format = DateTimePickerFormat.Short;
            buttEdit.Visible = false;
            cargardatos();
            formatoDGV.FormatearDataGridViews(this);
        }

        private string mvar;
        private string estado = "I";

        

        private void cargardatos()
        {
            String consulta = "SELECT * FROM proveedores";

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

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mvar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtdirecc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtvend.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fechaingreso.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            estado = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            if (estado == "A")
            {
                rjToggleButton1.Checked = true;
            }
            else
            {
                rjToggleButton1.Checked = false;
            }
            buttEdit.Visible = true;
            btagregar.Visible = false;
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked)
            {
                estado = "A";
            }
            else
            {
                estado = "I";
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

        private void btagregar_Click(object sender, EventArgs e)
        {
           
                Conectar cls = new Conectar();
                string datos = "'" + txtnombre.Text + "','" + txttel.Text + "','" + txtdirecc.Text + "','" + txtemail.Text + "','" + txtvend.Text + "','" + fechaingreso.Text + "','" + estado + "'";
                string tabla = "proveedores";
                cls.Agregar(datos, tabla);
                cargardatos();
                limpiar.LimpiarTextBoxes(this);
            
        }

        private void buttEdit_Click(object sender, EventArgs e)
        {
            
                Conectar cls = new Conectar();
                string up = "nomproveedor= '" + txtnombre.Text + "', tlfproveedor= '" + txttel.Text + "', direcproveedor= '" + txtdirecc.Text + "', emailproveedor= '" + txtemail.Text + "', vendedor= '" + txtvend.Text + "', fechaingreso= '" + fechaingreso.Text + "', estado= '" + estado + "'";
                string tbl = "proveedores";
                string id = "id_proveedor = '" + mvar + "'";
                cls.Actualizar(up, tbl, id);

                buttEdit.Visible = false;
                cargardatos();
                btagregar.Visible = true;
                limpiar.LimpiarTextBoxes(this);
            
        }
    }
}
