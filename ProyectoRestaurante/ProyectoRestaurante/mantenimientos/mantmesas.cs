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
    public partial class mantmesas : Form
    {
        public mantmesas()
        {
            InitializeComponent();
            fechamesa.Format = DateTimePickerFormat.Short;
            buttEdit.Visible = false;
            cargardatos();
        }

        private string mvar;
        private void btagregar_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = "" + cbbsala.SelectedValue + ",'" + txtmesa.Text + "'," + txtasientos.Text + ",'" + fechamesa.Text + "','"+txtestado.Text+"'";
            string tabla = "mesas";
            cls.Agregar(datos, tabla);
            cargardatos();
            limpiar.LimpiarTextBoxes(this);
        }
        
        private void mantmesas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet16.salas' Puede moverla o quitarla según sea necesario.
            this.salasTableAdapter4.Fill(this.proyectoRestauranteDataSet16.salas);

        }
        private void cargardatos()
        {
            String consulta = "SELECT * FROM mesas";
            
            try
            {
                using (SqlConnection conexion = new SqlConnection(rutadb.conexion))
                {
                    conexion.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;

                        // Configuración de columnas
                        if (dataGridView1.Columns.Contains("id_mesa")) dataGridView1.Columns["id_mesa"].DisplayIndex = 0;
                        if (dataGridView1.Columns.Contains("id_sala")) dataGridView1.Columns["id_sala"].DisplayIndex = 1;
                        if (dataGridView1.Columns.Contains("nommesa")) dataGridView1.Columns["nommesa"].DisplayIndex = 2;
                        if (dataGridView1.Columns.Contains("puestos")) dataGridView1.Columns["puestos"].DisplayIndex = 3;
                        if (dataGridView1.Columns.Contains("fecha")) dataGridView1.Columns["fecha"].DisplayIndex = 4;
                        if (dataGridView1.Columns.Contains("estado")) dataGridView1.Columns["estado"].DisplayIndex = 5;

                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }

        private void buttEdit_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string up = "id_sala ='" + cbbsala.SelectedValue + "',nommesa = "+"'"+ txtmesa.Text+ "',puestos ="+txtasientos.Text+", fecha ="+"'"+fechamesa.Text+"', estado ='"+txtestado.Text+"'";
            string tbl = "mesas";
            string id = "id_mesa = '" + mvar + "'";
            cls.Actualizar(up, tbl, id);

            buttEdit.Visible = false;
            cargardatos();
            btagregar.Visible = true;
            limpiar.LimpiarTextBoxes(this);
        }

        private void btcerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mvar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbbsala.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtmesa.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtasientos.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fechamesa.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtestado.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            buttEdit.Visible = true;
            btagregar.Visible = false;
        }
                
    }
}
