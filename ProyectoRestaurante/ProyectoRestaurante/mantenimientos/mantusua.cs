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
            string datos = "'"+txtnom.Text+"','"+txtsex.Text+"','"+txtdirec.Text+"','"+txttel.Text+"','"+txtemail.Text+"','"+txtusua.Text+"','"+txtpassw.Text+"',"+cbbnivel.SelectedValue+","+txtest.Text+"";
            string tabla = "usuarios";
            cls.Agregar(datos, tabla);
        }

        private void mantusua_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet8.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.proyectoRestauranteDataSet8.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet7.nivel' Puede moverla o quitarla según sea necesario.
            this.nivelTableAdapter.Fill(this.proyectoRestauranteDataSet7.nivel);

        }

        private void txtnom_DoubleClick(object sender, EventArgs e)
        {
            dvgmantusua dvgusua = new dvgmantusua();
            dvgusua.Show();

        }
    }
}
