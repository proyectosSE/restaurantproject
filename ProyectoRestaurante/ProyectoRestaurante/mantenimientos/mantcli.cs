using ProyectoRestaurante.clases;
using ProyectoRestaurante.mantenimientos;
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
    public partial class mantcli : Form
    {
        public static SqlConnection conexion = new SqlConnection(rutadb.conexion);
        public mantcli()
        {
            InitializeComponent();
            fechain.Format = DateTimePickerFormat.Short;
            bteditar.Visible = false;
                        
        }
        public string mvar;
        public string estado="I";


        private void buttAgregar_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = "'"+txtnom.Text+"','"+txtapell.Text+"','"+txtdirec.Text+"','"+txtemail.Text+"',"+txtlimicre.Text+",'"+fechain.Text+"','"+estado+"'";
            string tabla = "clientes";
            cls.Agregar(datos,tabla);
            limpiar.LimpiarTextBoxes(this);
        }
        

        private void txtnom_DoubleClick(object sender, EventArgs e)
        {
            dgvmantcli dgv = new dgvmantcli();
            AddOwnedForm(dgv);
            dgv.FormBorderStyle = FormBorderStyle.None;
            dgv.TopLevel = false;
            dgv.Dock = DockStyle.Fill;
            this.Controls.Add(dgv);
            this.Tag = dgv;
            dgv.BringToFront();
            dgv.Show();
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string up = "nomcliente= '"+txtnom.Text+"', apellidocliente= '"+txtapell.Text+"', direccliente= '"+txtdirec.Text+"', emailcliente= '"+txtemail.Text+"', limitecredito= "+txtlimicre.Text+", fechaingreso= '"+fechain.Text+"', estado= '"+estado+"'";
            string tabla = "clientes";
            string id = "id_cliente= '"+mvar+"'";
            cls.Actualizar(up,tabla,id);
            bteditar.Visible = false;
            buttAgregar.Visible = true;
            limpiar.LimpiarTextBoxes(this);
                        
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
    }
}
