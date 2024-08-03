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
        public static SqlConnection conexion = new SqlConnection("server=LAPTOP-ASISTENT;Database=ProyectoRestaurante;Integrated Security=true");
        public mantcli()
        {
            InitializeComponent();
        }

        private void buttAgregar_Click(object sender, EventArgs e)
        {
            String cadena = $"INSERT INTO clientes VALUES('{textNomb.Text}','{textApell.Text}','{textDirec.Text}',{textEmail.Text}',{textLimcre.Text}','{dateTime.Text}')";
            SqlCommand comando = new SqlCommand(cadena,conexion);
            comando.ExecuteNonQuery();

            MessageBox.Show("agregado exitosamente");

            textNomb.Text = "";
            textApell.Text = "";
            textDirec.Text = "";
            textEmail.Text = "";
            textLimcre.Text = "";
            
        }
    }
}
