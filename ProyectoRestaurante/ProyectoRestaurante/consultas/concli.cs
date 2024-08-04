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
    public partial class concli : Form
    {
        public concli()
        {
            InitializeComponent();
        }

        private void concli_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet10.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.proyectoRestauranteDataSet10.clientes);

        }
    }
}
