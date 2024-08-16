using ProyectoRestaurante.clases;
using RJCodeAdvance.RJControls;
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
            formatoDGV.FormatearDataGridViews(this);
        }
        string mvar;
        string estado = "I";

        private void btagregar_Click(object sender, EventArgs e)
        {
            if (verificar.campo(this))
            {
                mensaje ms = new mensaje("error", "Se encontraron campos vacios");
                ms.ShowDialog();
            }
            else
            {
                Conectar cls = new Conectar();
                string datos = "'" + txtsalas.Text + "','" + fechasala.Text + "','" + estado + "'";
                string tabla = "salas";
                cls.Agregar(datos, tabla);
                cargardatos();
                limpiar.LimpiarTextBoxes(this);
            }
                        
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
                        if (dataGridView1.Columns.Contains("estado")) dataGridView1.Columns["estado"].DisplayIndex = 3;

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
            if (verificar.campo(this))
            {
                mensaje ms = new mensaje("error", "Se encontraron campos vacios");
                ms.ShowDialog();
            }
            else
            {
                Conectar cls = new Conectar();
                string up = "nomsala ='" + txtsalas.Text + "', fecha = " + "'" + fechasala.Text + "', estado= '" + estado + "'";
                string tbl = "salas";
                string id = "id_sala = '" + mvar + "'";
                cls.Actualizar(up, tbl, id);

                buttEdit.Visible = false;
                cargardatos();
                btagregar.Visible = true;
                limpiar.LimpiarTextBoxes(this);
            }
                        
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mvar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtsalas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fechasala.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            estado = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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

    }
}
