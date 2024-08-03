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
    public partial class mantsalas : Form
    {
        public mantsalas()
        {
            InitializeComponent();
            fechasala.Format = DateTimePickerFormat.Short;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = "'"+txtsalas.Text+"','"+fechasala.Text+"'";
            string tabla = "salas";
            cls.Agregar(datos, tabla);
        }
    }
}
