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
    public partial class mantmesas : Form
    {
        public mantmesas()
        {
            InitializeComponent();
            fechamesa.Format = DateTimePickerFormat.Short;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = ""+cbbsala.SelectedValue+",'"+txtmesa.Text+"',"+txtasientos.Text+",'"+fechamesa.Text+"',"+txtestado.Text+"";
            string tabla = "mesas";
            cls.Agregar(datos, tabla);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mantmesas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet4.salas' Puede moverla o quitarla según sea necesario.
            this.salasTableAdapter3.Fill(this.proyectoRestauranteDataSet4.salas);
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet3.salas' Puede moverla o quitarla según sea necesario.
            this.salasTableAdapter2.Fill(this.proyectoRestauranteDataSet3.salas);
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet1.salas' Puede moverla o quitarla según sea necesario.
            this.salasTableAdapter1.Fill(this.proyectoRestauranteDataSet1.salas);
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet.salas' Puede moverla o quitarla según sea necesario.
            this.salasTableAdapter.Fill(this.proyectoRestauranteDataSet.salas);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
