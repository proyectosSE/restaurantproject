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
    public partial class mensaje : Form
    {
        public mensaje()
        {
            InitializeComponent();
        }

        private void buttCon_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttCan_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
