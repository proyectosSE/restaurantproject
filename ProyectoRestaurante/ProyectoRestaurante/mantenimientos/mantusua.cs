using ProyectoRestaurante.clases;
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
            bteditar.Visible = false;
        }

        public mantusua(int pId)
        {
            InitializeComponent();
            Buscar(pId);
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            if (verificar.campo(this))
            {
                mensaje ms = new mensaje("error", "Se encontraron campos vacios");
                ms.ShowDialog();
            }
            else
            {
                Conectar cls = new Conectar();
                string datos = "'" + txtnom.Text + "','" + txtsex.Text + "','" + txtdirec.Text + "','" + txttel.Text + "','" + txtemail.Text + "','" + txtusua.Text + "','" + txtpassw.Text + "'," + cbbnivel.SelectedValue + ",'" + estado + "'";
                string tabla = "usuarios";
                cls.Agregar(datos, tabla);
                limpiar.LimpiarTextBoxes(this);
            }
            
        }

        private void mantusua_Load(object sender, EventArgs e)
        {
            
        }

        private void Buscar(int pId)
        {

            string query = "SELECT * FROM usuarios WHERE id_usuario = " + pId + "";

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
                                estado = reader["status"].ToString();
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
            AddOwnedForm(dvgusua);
            dvgusua.FormBorderStyle = FormBorderStyle.None;
            dvgusua.TopLevel = false;
            dvgusua.Dock = DockStyle.Fill;
            this.Controls.Add(dvgusua);
            this.Tag = dvgusua;
            dvgusua.BringToFront();
            dvgusua.Show();

        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string mvar;
        public string estado="I";
        private void bteditar_Click(object sender, EventArgs e)
        {
            if (verificar.campo(this))
            {
                mensaje ms = new mensaje("error", "Se encontraron campos vacios");
                ms.ShowDialog();
            }
            else
            {
                Conectar cls = new Conectar();
                string up = "nombres= '" + txtnom.Text + "', sexo= '" + txtsex.Text + "', direccion= '" + txtdirec.Text + "', telefono= '" + txttel.Text + "', email= '" + txtemail.Text + "', usuario= '" + txtusua.Text + "', password= '" + txtpassw.Text + "', id_nivel= " + cbbnivel.SelectedValue + ", estado= '" + estado + "'";
                string tabla = "usuarios";
                string id = "id_usuario= '" + mvar + "'";
                cls.Actualizar(up, tabla, id);
                bteditar.Visible = false;
                btagregar.Visible = true;
                limpiar.LimpiarTextBoxes(this);
            }
                        
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked)
            {
                estado = "A";
            }
            else
            {
                estado = "I";
            }
        }
    }
}
