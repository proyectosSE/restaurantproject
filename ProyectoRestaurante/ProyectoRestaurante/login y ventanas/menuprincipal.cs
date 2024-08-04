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

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            mantcli mantenicli = new mantcli(); 
            mantenicli.Show();

        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            mantcat mantenicat = new mantcat();
            mantenicat.Show();
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            mantsalas mantenisalas = new mantsalas();
            mantenisalas.Show();
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            mantmesas mantenimesas = new mantmesas();
            mantenimesas.Show();
        }

        private void iconMenuItem5_Click(object sender, EventArgs e)
        {
            mantusua manteniusua = new mantusua();
            manteniusua.Show();
        }

        private void iconMenuItem6_Click(object sender, EventArgs e)
        {
            mantdepar mantenidepar = new mantdepar();
            mantenidepar.Show();
        }

        private void iconMenuItem7_Click(object sender, EventArgs e)
        {
            mantmedid mantenimedid = new mantmedid();
            mantenimedid.Show();
        }

        private void menuprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            login lg = new login();
            lg.Show();
        }

        private void iconMenuItem11_Click(object sender, EventArgs e)
        {
            conmesa cm = new conmesa();
            cm.Show();
        }

        private void iconMenuItem8_Click(object sender, EventArgs e)
        {
            concli ccli = new concli();
            ccli.Show();
        }

        private void iconMenuItem9_Click(object sender, EventArgs e)
        {
            concat ccat = new concat();
            ccat.Show();
        }

        private void iconMenuItem10_Click(object sender, EventArgs e)
        {
            consalas csalas = new consalas();
            csalas.Show();
        }

        private void iconMenuItem13_Click(object sender, EventArgs e)
        {
            condepart condepart = new condepart();
            condepart.Show();
        }
    }
}
