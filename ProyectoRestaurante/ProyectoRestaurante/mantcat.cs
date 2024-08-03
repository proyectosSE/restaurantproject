using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante
{
    public partial class mantcat : Form
    {
        public mantcat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string categoria ="'"+textcat.Text+"'";
            string tbcat = "categorias";            
            cls.Agregar(categoria,tbcat);
        }
    }
}
