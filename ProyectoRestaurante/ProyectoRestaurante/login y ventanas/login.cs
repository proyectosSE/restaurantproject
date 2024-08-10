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
using System.Runtime.InteropServices;


namespace ProyectoRestaurante
{
    public partial class login : Form
    {

        public static SqlConnection conexion = new SqlConnection(rutadb.conexion);

        public login()
        {
            InitializeComponent();
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
                
        
        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
           // conexion.Close();
        }

        private void txtlogin_Enter(object sender, EventArgs e)
        {
            if (txtlogin.Text == "USUARIO")
            {
                txtlogin.Text = "";
                txtlogin.ForeColor = Color.LightGray;
            }
        }

        private void txtlogin_Leave(object sender, EventArgs e)
        {
            if (txtlogin.Text == "")
            {
                txtlogin.Text = "USUARIO";
                txtlogin.ForeColor = Color.LightGray;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "PASSWORD")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.LightGray;
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "PASSWORD";
                txtpassword.ForeColor = Color.LightGray;
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
                
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void rjButton1_Click(object sender, EventArgs e)
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

        private void rjButton1_MouseEnter(object sender, EventArgs e)
        {
            rjButton1.BackColor = Color.Gold;
        }

        private void rjButton1_MouseLeave(object sender, EventArgs e)
        {
            rjButton1.BackColor = Color.White;
        }
    }
}
