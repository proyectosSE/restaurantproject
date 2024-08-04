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

namespace ProyectoRestaurante
{
    public partial class login : Form
    {

        public static SqlConnection conexion = new SqlConnection(rutadb.conexion);

        public login()
        {
            InitializeComponent();
        }

        private void btsalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btentrar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string entrar = "SELECT * FROM usuarios WHERE usuario='" + txtlogin.Text + "' AND password ='" + txtpassword.Text + "'";
            SqlCommand comando = new SqlCommand(entrar, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                menuprincipal men = new menuprincipal();
                men.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");
            }
            conexion.Close();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
           // conexion.Close();
        }
    }
}
