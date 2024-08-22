using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante.login_y_ventanas
{
    public partial class productos : UserControl
    {
        private int id = 0;
        
        public productos()
        {
            InitializeComponent();
        }
        public event EventHandler seleccion = null;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Producto
        {
            get { return nomprod.Text; }
            set { nomprod.Text = value; }
        }

        public string Precio
        {
            get { return precioprod.Text; }
            set { precioprod.Text = value; }
        }

        public Image ImagenProd
        {
            get { return prodimagen.Image; }
            set { prodimagen.Image = value; }
        }

        public void prodimagen_DoubleClick(object sender, EventArgs e)
        {
            seleccion?.Invoke(this, e);
        }
    }
}
