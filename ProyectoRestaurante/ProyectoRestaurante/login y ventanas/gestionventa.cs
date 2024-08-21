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
        private string consulta2;

        private void llenarmesas ()
        {
            DBmesa db = new DBmesa();
            db.Llenarbotones(flowLayoutPanel1,consulta);
        }

        private void llenarproductos()
        {
            DBproductos db = new DBproductos();
            db.LlenarProductos(flowLayoutPanel2, consulta2);
        }
                

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = flowLayoutPanel1.Controls.Count - 1; i >= 0; i--)
            {
                Control control = flowLayoutPanel1.Controls[i];
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose(); 
            }

            consulta = $"SELECT * FROM mesas WHERE id_sala = {comboBox1.SelectedValue}";
            llenarmesas();              
                        
        }

        private void cbbcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = flowLayoutPanel2.Controls.Count - 1; i >= 0; i--)
            {
                Control control = flowLayoutPanel2.Controls[i];
                flowLayoutPanel2.Controls.Remove(control);
                control.Dispose();
            }

            consulta2 = $"SELECT * FROM productos WHERE id_categoria = {cbbcat.SelectedValue}";
            llenarproductos();
        }

        private void gestionventa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet28.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.proyectoRestauranteDataSet28.categorias);
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet27.salas' Puede moverla o quitarla según sea necesario.
            this.salasTableAdapter1.Fill(this.proyectoRestauranteDataSet27.salas);

        }

        private void mesas1_Load(object sender, EventArgs e)
        {

        }

    }
}
