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
            PictureBox1.Image = Properties.Resources.experiencia_del_cliente;
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
                    PictureBox1.Image = Properties.Resources.experiencia_del_cliente;
                    break;
                case 1:
                    AbrirF(new conmesa());
                    PictureBox1.Image = Properties.Resources.dinning_room;
                    break;
                case 2:
                    AbrirF(new consalas());
                    PictureBox1.Image = Properties.Resources.icons8_room_96;
                    break;
                case 3:
                    AbrirF(new concat());
                    PictureBox1.Image = Properties.Resources.menu;
                    break;
                case 4:
                    AbrirF(new conusua());
                    PictureBox1.Image = Properties.Resources.agregar_usuario;
                    break;
                case 5:
                    AbrirF(new condepart());
                    PictureBox1.Image = Properties.Resources.departamento;
                    break;
                case 6:
                    AbrirF(new conmedidas());
                    PictureBox1.Image = Properties.Resources.perdida_de_peso;
                    break;
                case 7:
                    AbrirF(new conprov());
                    PictureBox1.Image = Properties.Resources.proveedores;
                    break;
                case 8:
                    //productos
                    //PictureBox1.Image = Properties.Resources.empanada;
                    break;
                case 9:
                    AbrirF(new conmon());
                    PictureBox1.Image = Properties.Resources.money_4751693;
                    break;
                case 10:
                    AbrirF(new conimp());
                    PictureBox1.Image = Properties.Resources.bill_1730347;
                    break;
                default:
                    MessageBox.Show("Ítem desconocido");
                    break;
            }
        }
    }
}
