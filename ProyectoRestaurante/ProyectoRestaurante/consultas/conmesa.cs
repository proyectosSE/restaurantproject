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
    public partial class conmesa : Form
    {
        public conmesa()
        {
            InitializeComponent();
        }

        private void conmesa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet9.mesas' Puede moverla o quitarla según sea necesario.
            this.mesasTableAdapter.Fill(this.proyectoRestauranteDataSet9.mesas);

        }
    }
}
