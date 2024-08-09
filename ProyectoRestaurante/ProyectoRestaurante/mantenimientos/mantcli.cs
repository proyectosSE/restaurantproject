using ProyectoRestaurante.clases;
using ProyectoRestaurante.mantenimientos;
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

namespace ProyectoRestaurante
{
    public partial class mantcli : Form
    {
        public static SqlConnection conexion = new SqlConnection(rutadb.conexion);
        public mantcli()
        {
            InitializeComponent();
            fechain.Format = DateTimePickerFormat.Short;
            bteditar.Visible = false;
                        
        }

        public mantcli(int pId)
        {
            InitializeComponent();
            fechain.Format = DateTimePickerFormat.Short;
            Buscar(pId);

        }

        private void buttAgregar_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = "'"+txtnom.Text+"','"+txtapell.Text+"','"+txtdirec.Text+"','"+txtemail.Text+"',"+txtlimicre.Text+",'"+fechain.Text+"','"+txtest.Text+"'";
            string tabla = "clientes";
            cls.Agregar(datos,tabla);
            limpiar.LimpiarTextBoxes(this);
        }

        private void Buscar(int pId)
        {
           
            string query = "SELECT * FROM clientes WHERE id_cliente = "+pId+"";

            using (SqlConnection connection = new SqlConnection(rutadb.conexion))
            {
                try
                {
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("id_cliente", pId);

                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            
                            if (reader.Read())
                            {
                                
                                txtnom.Text = reader["nomcliente"].ToString();
                                txtapell.Text = reader["apellidocliente"].ToString();
                                txtdirec.Text = reader["direccliente"].ToString();
                                txtemail.Text = reader["emailcliente"].ToString();
                                txtlimicre.Text = reader["limitecredito"].ToString();
                                fechain.Text = reader["fechaingreso"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtnom_DoubleClick(object sender, EventArgs e)
        {
            dgvmantcli dgv = new dgvmantcli();
            AddOwnedForm(dgv);
            dgv.FormBorderStyle = FormBorderStyle.None;
            dgv.TopLevel = false;
            dgv.Dock = DockStyle.Fill;
            this.Controls.Add(dgv);
            this.Tag = dgv;
            dgv.BringToFront();
            dgv.Show();
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string mvar;
        private void bteditar_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string up = "nomcliente= '"+txtnom.Text+"', apellidocliente= '"+txtapell.Text+"', direccliente= '"+txtdirec.Text+"', emailcliente= '"+txtemail.Text+"', limitecredito= "+txtlimicre.Text+", fechaingreso= '"+fechain.Text+"', estado= '"+txtest.Text+"'";
            string tabla = "clientes";
            string id = "id_cliente= '"+mvar+"'";
            cls.Actualizar(up,tabla,id);
            bteditar.Visible = false;
            buttAgregar.Visible = true;
            limpiar.LimpiarTextBoxes(this);
        }
    }
}
