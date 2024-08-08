using ProyectoRestaurante.consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante
{
    public partial class menuprincipal : Form
    {
        public menuprincipal()
        {
            InitializeComponent();
            
        }

        private void menuprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            login lg = new login();
            lg.Show();
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirF(object Fhijo)
        {
            if (this.contenedor.Controls.Count > 0)
            {
                this.contenedor.Controls.RemoveAt(0);
            }
            Form fh = Fhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(fh);
            this.contenedor.Tag = fh;
            fh.Show();
        }

        private void btmantenimiento_Click(object sender, EventArgs e)
        {
            AbrirF(new hubmante());
        }

        private void btcerrar_MouseEnter(object sender, EventArgs e)
        {
            btcerrar.BackColor = Color.Gold;
        }

        private void btcerrar_MouseLeave(object sender, EventArgs e)
        {
            btcerrar.BackColor= Color.Black;
        }

        private void btminimizar_MouseEnter(object sender, EventArgs e)
        {
            btminimizar.BackColor = Color.Gold;
        }

        private void btminimizar_MouseLeave(object sender, EventArgs e)
        {
            btminimizar.BackColor= Color.Black;
        }
    }
}
