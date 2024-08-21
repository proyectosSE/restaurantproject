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
                
        public mantproductos()
        {
            InitializeComponent();
            fechaelab.Format = DateTimePickerFormat.Short;
            btedit.Visible = false;
        }
        public string mvar;
        public string ITBIS = "N";
        public string preparado = "N";
        public string estado = "I";
        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "archivos de imagen (*png;) |*png; ";
            DialogResult rs = ofd.ShowDialog();

            if(rs == DialogResult.OK)
            {
                ImagenProducto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            byte[] fotobyte = convertirbytes(ImagenProducto);

            string datos = "'" + txtproducto.Text + "', " + cbbcat.SelectedValue + ", " + cbbproveedor.SelectedValue + ", " + txtpreciocomp.Text + ", " + txtpreciovent.Text + ", " + txtstock.Text + ", '" + ITBIS + "', " + txtdescuento.Text + ", '" + fechaelab.Text + "', '" + preparado + "', @imagen , '" + estado + "'";
            string tabla = "productos";
            cls.Agregar(datos, tabla, fotobyte);
            limpiar.LimpiarTextBoxes(this);

        }

        private void btITBIS_CheckedChanged(object sender, EventArgs e)
        {
            if(btITBIS.Checked)
            {
                ITBIS = "S";
            }
            else
            {
                ITBIS = "N";
            }
        }

        private void btpreparado_CheckedChanged(object sender, EventArgs e)
        {
            if (btpreparado.Checked)
            {
                preparado = "S";
            }
            else
            {
                preparado = "N";
            }
        }

        private void btestado_CheckedChanged(object sender, EventArgs e)
        {
            if(btestado.Checked)
            {
                estado = "A";
            }
            else
            {
                estado = "I";
            }
        }

        private void mantproductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet30.proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter2.Fill(this.proyectoRestauranteDataSet30.proveedores);
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet29.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter2.Fill(this.proyectoRestauranteDataSet29.categorias);


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

        private void btedit_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            byte[] fotobyte = convertirbytes(ImagenProducto);

            string datos = "producto= '" + txtproducto.Text + "', id_categoria= " + cbbcat.SelectedValue + ", id_proveedor= " + cbbproveedor.SelectedValue + ", preciocompra= " + txtpreciocomp.Text + ", precioventa= " + txtpreciovent.Text + ", existencia= " + txtstock.Text + ", itbisproducto= '" + ITBIS + "', descproducto= " + txtdescuento.Text + ", fechaelaboracion= '" + fechaelab.Text + "', preparado= '" + preparado + "', imagen= @imagen, estado= '" + estado + "'";
            string tabla = "productos";
            string id = "id_producto= '" + mvar + "'";
            cls.Actualizar(datos, tabla, fotobyte, id);
            btagregar.Visible = true;
            btedit.Visible = false;
        }

        public byte[] convertirbytes(PictureBox foto)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                foto.Image.Save(ms, foto.Image.RawFormat);
                return ms.ToArray();
            }
        }

    }
}
