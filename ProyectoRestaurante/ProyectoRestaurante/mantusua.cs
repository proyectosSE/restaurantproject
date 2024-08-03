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
    public partial class mantusua : Form
    {
        public mantusua()
        {
            InitializeComponent();
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = "'"+txtnom.Text+"','"+txtsex.Text+"','"+txtdirec.Text+"','"+txttel.Text+"','"+txtemail.Text+"','"+txtusua.Text+"','"+txtpassw.Text+"',"+cbbnivel+","+txtest.Text+","+txtcomis.Text+"";
            string tabla = "usuarios";
            cls.Agregar(datos, tabla);
        }

        private void mantusua_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet2.nivel' Puede moverla o quitarla según sea necesario.
            this.nivelTableAdapter.Fill(this.proyectoRestauranteDataSet2.nivel);

        }
    }
}
