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
    public partial class mantusua : Form
    {
        public mantusua()
        {
            InitializeComponent();
        }

        public mantusua(int pId)
        {
            InitializeComponent();
            Buscar(pId);
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
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet15.nivel' Puede moverla o quitarla según sea necesario.
            this.nivelTableAdapter1.Fill(this.proyectoRestauranteDataSet15.nivel);


        }

        private void Buscar(int pId)
        {

            string query = "SELECT * FROM usuarios WHERE id_cliente = " + pId + "";

            using (SqlConnection connection = new SqlConnection(rutadb.conexion))
            {
                try
                {
                    connection.Open();


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("id_usuario", pId);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {

                                txtnom.Text = reader["nombres"].ToString();
                                txtsex.Text = reader["sexo"].ToString();
                                txtdirec.Text = reader["direccion"].ToString();
                                txttel.Text = reader["telefono"].ToString();
                                txtemail.Text = reader["email"].ToString();
                                txtusua.Text = reader["usuario"].ToString();
                                txtpassw.Text = reader["password"].ToString();
                                cbbnivel.SelectedValue = reader["id_nivel"].ToString();
                                txtest.Text = reader["status"].ToString();
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
            dvgmantusua dvgusua = new dvgmantusua();
            dvgusua.Show();

        }
    }
}
