using ProyectoRestaurante.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante.login_y_ventanas
{
    public partial class gestionventa : Form
    {
        public gestionventa()
        {
            InitializeComponent();
        }

        private string consulta;

        private void llenarmesas ()
        {
            DBmesa db = new DBmesa();
            db.Llenarbotones(flowLayoutPanel1,consulta);
        }

        

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
                consulta = $"SELECT * FROM mesas WHERE id_sala = {comboBox1.SelectedValue}";
                llenarmesas();
            
        }

        private void gestionventa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet26.salas' Puede moverla o quitarla según sea necesario.
            this.salasTableAdapter.Fill(this.proyectoRestauranteDataSet26.salas);

        }
    }
}
