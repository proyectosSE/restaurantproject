using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using ProyectoRestaurante.clases;

namespace ProyectoRestaurante.mantenimientos
{
    public partial class mantproductos : Form
    {
        SqlConnection conexion = new SqlConnection("server=ELIASPC;Database=ProyectoRestaurante;Integrated Security=true");
        
        public mantproductos()
        {
            InitializeComponent();
            fechaelab.Format = DateTimePickerFormat.Short;
            btedit.Visible = false;
        }
        public string ITBIS;
        public string preparado;
        public string estado;
        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "archivos de imagen (*jpg; *png;) |*jpg; *png; ";
            DialogResult rs = ofd.ShowDialog();

            if(rs == DialogResult.OK)
            {
                ImagenProducto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btagregar_Click(object sender, EventArgs e)
        {            
            MemoryStream ms = new MemoryStream();
            ImagenProducto.Image.Save(ms,ImageFormat.Jpeg);
            byte[] fotobyte = ms.ToArray();

            conexion.Open();
            string datos = "INSERT INTO productos VALUES('"+txtproducto.Text+"', "+cbbcat.SelectedValue+", "+cbbproveedor.SelectedValue+", "+txtpreciocomp.Text+", "+txtpreciovent.Text+", "+txtstock.Text+", '"+ITBIS+"', "+txtdescuento.Text+", '"+fechaelab.Text+"', '"+preparado+"', @imagen , '"+estado+"')";
            SqlCommand comando = new SqlCommand(datos,conexion);
            comando.Parameters.AddWithValue("imagen", fotobyte);
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos Guardados");
            limpiar.LimpiarTextBoxes(this);
            conexion.Close();
        }

        private void btITBIS_CheckedChanged(object sender, EventArgs e)
        {
            if(btITBIS.Checked == true)
            {
                ITBIS = "S";
            }
            else if(btITBIS.Checked == false)
            {
                ITBIS = "N";
            }
        }

        private void btpreparado_CheckedChanged(object sender, EventArgs e)
        {
            if (btpreparado.Checked == true)
            {
                preparado = "S";
            }
            else if(btpreparado.Checked == false)
            {
                preparado = "N";
            }
        }

        private void btestado_CheckedChanged(object sender, EventArgs e)
        {
            if(btestado.Checked == true)
            {
                estado = "A";
            }
            else if(btestado.Checked == false)
            {
                estado = "I";
            }
        }

        private void mantproductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet21.proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.proyectoRestauranteDataSet21.proveedores);
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet20.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.proyectoRestauranteDataSet20.categorias);

        }

        private void txtproducto_DoubleClick(object sender, EventArgs e)
        {
            dgvprod prod = new dgvprod();
            AddOwnedForm(prod);
            prod.FormBorderStyle = FormBorderStyle.None;
            prod.TopLevel = false;
            prod.Dock = DockStyle.Fill;
            this.Controls.Add(prod);
            this.Tag = prod;
            prod.BringToFront();
            prod.Show();
        }
    }
}
