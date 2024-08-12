using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ProyectoRestaurante.consultas
{
    public partial class consultasG : Form
    {
        public consultasG()
        {
            InitializeComponent();
            ComboBox.Items.AddRange(new object[] { "Clientes", "Mesas", "Salas", "Categorias", "Usuarios", "Departamentos", "Medidas", "Proveedores", "Productos", "Monedas", "Impuestos" });
            ComboBox.SelectedIndex = 0;
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AbrirF(object Fhijo)
        {
            if (this.contenedor.Controls.Count > 0)
            {
                this.contenedor.Controls.RemoveAt(0);
            }
            Form fh = Fhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(fh);
            this.contenedor.Tag = fh;
            fh.Show();
        }

        private void ComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ComboBox.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    AbrirF(new concli());
                    break;
                case 1:
                    AbrirF(new conmesa());
                    break;
                case 2:
                    AbrirF(new consalas());
                    break;
                case 3:
                    AbrirF(new concat());
                    break;
                case 4:
                    AbrirF(new conusua());
                    break;
                case 5:
                    AbrirF(new condepart());
                    break;
                case 6:
                    AbrirF(new conmedidas());
                    break;
                case 7:
                    AbrirF(new conprov());
                    break;
                case 8:
                    //productos
                    break;
                case 9:
                    AbrirF(new conmon());
                    break;
                case 10:
                    AbrirF(new conimp());
                    break;
                default:
                    MessageBox.Show("Ítem desconocido");
                    break;
            }
        }
    }
}
