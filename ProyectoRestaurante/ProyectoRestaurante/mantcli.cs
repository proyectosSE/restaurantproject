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
        public static SqlConnection conexion = new SqlConnection("server=ELIASPC;Database=ProyectoRestaurante;Integrated Security=true");
        public mantcli()
        {
            InitializeComponent();
            fechain.Format = DateTimePickerFormat.Short;
        }

        private void buttAgregar_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = "'"+txtnom.Text+"','"+txtapell.Text+"','"+txtdirec.Text+"','"+txtemail.Text+"',"+txtlimicre.Text+",'"+fechain.Text+"'";
            string tabla = "clientes";
            cls.Agregar(datos,tabla);
        }
    }
}
