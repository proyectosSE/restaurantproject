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
using System.IO;

namespace ProyectoRestaurante.mantenimientos
{
    public partial class dgvprod : Form
    {
        public dgvprod()
        {
            InitializeComponent();
            cargadatos();
            formatoDGV.FormatearDataGridViews(this);
        }

        public void cargadatos()
        {
            string consulta = "SELECT * FROM productos";
            try
            {
                using (SqlConnection conexion = new SqlConnection(rutadb.conexion))
                {
                    conexion.Open();

                    using (SqlDataAdapter ad = new SqlDataAdapter(consulta, conexion))
                    {
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        dataGridView1.DataSource = dt;

                        if (dataGridView1.Columns.Contains("id_productos")) dataGridView1.Columns["id_provincia"].DisplayIndex=0;
                        if (dataGridView1.Columns.Contains("producto")) dataGridView1.Columns["producto"].DisplayIndex = 1;
                        if (dataGridView1.Columns.Contains("id_categoria")) dataGridView1.Columns["id_categoria"].DisplayIndex = 2;
                        if (dataGridView1.Columns.Contains("id_proveedor")) dataGridView1.Columns["id_proveedor"].DisplayIndex = 3;
                        if (dataGridView1.Columns.Contains("preciocompra")) dataGridView1.Columns["preciocompra"].DisplayIndex = 4;
                        if (dataGridView1.Columns.Contains("precioventa")) dataGridView1.Columns["precioventa"].DisplayIndex = 5;
                        if (dataGridView1.Columns.Contains("existencia")) dataGridView1.Columns["existencia"].DisplayIndex = 6;
                        if (dataGridView1.Columns.Contains("itbisproducto")) dataGridView1.Columns["itbisproducto"].DisplayIndex = 7;
                        if (dataGridView1.Columns.Contains("descproducto")) dataGridView1.Columns["descproducto"].DisplayIndex = 8;
                        if (dataGridView1.Columns.Contains("fechaelaboracion")) dataGridView1.Columns["fechaelaboracion"].DisplayIndex = 9;
                        if (dataGridView1.Columns.Contains("preparado")) dataGridView1.Columns["preparado"].DisplayIndex = 10;
                        if (dataGridView1.Columns.Contains("imagen")) dataGridView1.Columns["imagen"].Visible = false;
                        if (dataGridView1.Columns.Contains("estado")) dataGridView1.Columns["estado"].DisplayIndex = 12;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos, " + ex);
            }
            
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mantproductos mtprod = Owner as mantproductos;
            mtprod.mvar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            mtprod.txtproducto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mtprod.cbbcat.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mtprod.cbbproveedor.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mtprod.txtpreciocomp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mtprod.txtpreciovent.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            mtprod.txtstock.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            mtprod.ITBIS = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            if (mtprod.ITBIS == "S")
            {
                mtprod.btITBIS.Checked = true;
            }
            else
            {
                mtprod.btITBIS.Checked = false;
            }
            mtprod.txtdescuento.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            mtprod.fechaelab.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            mtprod.preparado = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            if (mtprod.preparado == "S")
            {
                mtprod.btpreparado.Checked = true;
            }
            else
            {
                mtprod.btpreparado.Checked = false;
            }
            byte[] foto = (byte[])dataGridView1.CurrentRow.Cells[11].Value;
            
            using (var stream = new MemoryStream(foto))
            {
                    mtprod.ImagenProducto.Image = Image.FromStream(stream);
            }             
                             
            mtprod.estado = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            if (mtprod.estado == "A")
            {
                mtprod.btestado.Checked = true;
            }
            else
            {
                mtprod.btestado.Checked = false;
            }
            mtprod.btagregar.Visible = false;
            mtprod.btedit.Visible = true;
            this.Close();
        }
    }
}
