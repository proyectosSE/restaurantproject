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
    public partial class consalas : Form
    {
        public consalas()
        {
            InitializeComponent();
        }

        private void consalas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet13.salas' Puede moverla o quitarla según sea necesario.
            this.salasTableAdapter.Fill(this.proyectoRestauranteDataSet13.salas);

        }
    }
}
