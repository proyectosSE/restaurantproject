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
    public partial class hubmante : Form
    {
        public hubmante()
        {
            InitializeComponent();
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mantcli mantcliente = new mantcli();
            mantcliente.FormBorderStyle = FormBorderStyle.None;
            mantcliente.TopLevel = false;
            mantcliente.Dock = DockStyle.Fill;
            this.Controls.Add(mantcliente);
            this.Tag = mantcliente;
            mantcliente.BringToFront();
            mantcliente.Show();
        }

        private void btmesa_Click(object sender, EventArgs e)
        {
            mantmesas mantmesa = new mantmesas();
            mantmesa.FormBorderStyle = FormBorderStyle.None;
            mantmesa.TopLevel = false;
            mantmesa.Dock = DockStyle.Fill;
            this.Controls.Add(mantmesa);
            this.Tag = mantmesa;
            mantmesa.BringToFront();
            mantmesa.Show();
        }

        private void btsala_Click(object sender, EventArgs e)
        {
            mantsalas mantsala = new mantsalas();
            mantsala.FormBorderStyle = FormBorderStyle.None;
            mantsala.TopLevel = false;
            mantsala.Dock = DockStyle.Fill;
            this.Controls.Add(mantsala);
            this.Tag = mantsala;
            mantsala.BringToFront();
            mantsala.Show();
        }

        private void btcli_MouseEnter(object sender, EventArgs e)
        {
            btcli.BackColor = Color.Gray;
        }

        private void btcli_MouseLeave(object sender, EventArgs e)
        {
            btcli.BackColor = Color.Black;
        }

        private void btmesa_MouseEnter(object sender, EventArgs e)
        {
            btmesa.BackColor = Color.Gray;
        }

        private void btmesa_MouseLeave(object sender, EventArgs e)
        {
            btmesa.BackColor = Color.Black;
        }

        private void btsala_MouseEnter(object sender, EventArgs e)
        {
            btsala.BackColor = Color.Gray;
        }

        private void btsala_MouseLeave(object sender, EventArgs e)
        {
            btsala.BackColor = Color.Black;
        }

        private void btcerrar_MouseEnter(object sender, EventArgs e)
        {
            btcerrar.BackColor = Color.Gray;
        }

        private void btcerrar_MouseLeave(object sender, EventArgs e)
        {
            btcerrar.BackColor = Color.Black;
        }

        private void btcate_Click(object sender, EventArgs e)
        {
            mantcat mantcateg = new mantcat();
            mantcateg.FormBorderStyle = FormBorderStyle.None;
            mantcateg.TopLevel = false;
            mantcateg.Dock = DockStyle.Fill;
            this.Controls.Add(mantcateg);
            this.Tag = mantcateg;
            mantcateg.BringToFront();
            mantcateg.Show();
        }

        private void btusua_Click(object sender, EventArgs e)
        {
            mantusua mantusua = new mantusua();
            mantusua.FormBorderStyle = FormBorderStyle.None;
            mantusua.TopLevel = false;
            mantusua.Dock = DockStyle.Fill;
            this.Controls.Add(mantusua);
            this.Tag = mantusua;
            mantusua.BringToFront();
            mantusua.Show();
        }

        private void btdepart_Click(object sender, EventArgs e)
        {
            mantdepar mantdpt = new mantdepar();
            mantdpt.FormBorderStyle = FormBorderStyle.None;
            mantdpt.TopLevel = false;
            mantdpt.Dock = DockStyle.Fill;
            this.Controls.Add(mantdpt);
            this.Tag = mantdpt;
            mantdpt.BringToFront();
            mantdpt.Show();
        }

        private void btmedida_Click(object sender, EventArgs e)
        {
            mantmedid mantmed = new mantmedid();
            mantmed.FormBorderStyle = FormBorderStyle.None;
            mantmed.TopLevel = false;
            mantmed.Dock = DockStyle.Fill;
            this.Controls.Add( mantmed);
            this.Tag = mantmed;
            mantmed.BringToFront();
            mantmed.Show();
        }

        private void btcate_MouseEnter(object sender, EventArgs e)
        {
            btcate.BackColor = Color.Gray;
        }

        private void btcate_MouseLeave(object sender, EventArgs e)
        {
            btcate.BackColor= Color.Black;
        }

        private void btusua_MouseEnter(object sender, EventArgs e)
        {
            btusua.BackColor = Color.Gray;
        }

        private void btusua_MouseLeave(object sender, EventArgs e)
        {
            btusua.BackColor= Color.Black;
        }

        private void btdepart_MouseEnter(object sender, EventArgs e)
        {
            btdepart.BackColor = Color.Gray;
        }

        private void btdepart_MouseLeave(object sender, EventArgs e)
        {
            btdepart.BackColor= Color.Black;
        }

        private void btmedida_MouseEnter(object sender, EventArgs e)
        {
            btmedida.BackColor = Color.Gray;
        }

        private void btmedida_MouseLeave(object sender, EventArgs e)
        {
            btmedida.BackColor= Color.Black;
        }
    }
}
