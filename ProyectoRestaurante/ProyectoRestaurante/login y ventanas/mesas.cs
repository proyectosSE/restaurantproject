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
    public partial class mesas : UserControl
    {
        private int id=0;
        

        public mesas()
        {
            InitializeComponent();
        }

        public int Id
        {
            get {return id;}
            set {id = value;}
        }

       public string Mesa
        {
            get { return mesanom.Text; }
            set { mesanom.Text = value; }
        }

        public string Asientos
        {
            get { return cantasientos.Text; }
            set {  cantasientos.Text = value;}

        }

        public string Total
        {
            get { return total.Text; }
            set { total.Text = value; }

        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
