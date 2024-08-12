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
    public partial class mensaje : Form
    {
        public mensaje()
        {
            InitializeComponent();
        }

        public mensaje(string pTipo, string pMensaje)
        {
            InitializeComponent();
            plisto.Visible = false;
            perror.Visible = false;
            ppregunta.Visible = false;
            
            label1.Text = pMensaje;
            switch (pTipo)
            {
                case "pregunta":
                    label2.Text = "CONFIRMACION?";                    
                    ppregunta.Visible = true;
                    break;
                case "listo":
                    label2.Text = "LISTO";                    
                    plisto.Visible = true;
                    rjButton2.Visible = false;
                    break;
                case "error":
                    label2.Text = "ERROR";                  
                    perror.Visible = true;
                    rjButton2.Visible = false;
                    break;
                default:
                    label2.Text = "ERROR";
                    break;
            }
        }



        private void rjButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
