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
            cargardatos();
        }

        private string mivar;
        private void button2_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = ""+cbbsala.SelectedValue+",'"+txtmesa.Text+"',"+txtasientos.Text+",'"+fechamesa.Text+"',"+txtestado.Text+"";
            string tabla = "mesas";
            cls.Agregar(datos, tabla);
            cargardatos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mantmesas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet14.salas' Puede moverla o quitarla según sea necesario.
            this.salasTableAdapter3.Fill(this.proyectoRestauranteDataSet14.salas);



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
                        if (dataGridView1.Columns.Contains("statusmesa")) dataGridView1.Columns["statusmesa"].DisplayIndex = 5;
                        if (dataGridView1.Columns.Contains("editar")) dataGridView1.Columns["editar"].DisplayIndex = 6;
                        if (dataGridView1.Columns.Contains("eliminar")) dataGridView1.Columns["eliminar"].DisplayIndex = 7;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                cbbsala.SelectedValue = dataGridView1.CurrentRow.Cells["id_sala"].Value.ToString();
                txtmesa.Text = dataGridView1.CurrentRow.Cells["nommesa"].Value.ToString();
                txtasientos.Text = dataGridView1.CurrentRow.Cells["puestos"].Value.ToString();
                fechamesa.Text = dataGridView1.CurrentRow.Cells["fecha"].Value.ToString();
                txtestado.Text = dataGridView1.CurrentRow.Cells["statusmesa"].Value.ToString();
                mivar = dataGridView1.CurrentRow.Cells["id_mesa"].Value.ToString();
                buttEdit.Visible = true;
                button1.Visible = false;

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                mensaje ms = new mensaje();

                if (ms.ShowDialog() == DialogResult.OK)
                {
                    mivar = dataGridView1.CurrentRow.Cells["id_mesa"].Value.ToString();
                    Conectar cls = new Conectar();
                    string tbl = "mesas";
                    string id = "id_mesa = '" + mivar + "'";
                    cls.eliminar(tbl, id);
                    cargardatos();
                }
            }
        }

        private void buttEdit_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string up = "id_sala ='" + cbbsala.SelectedValue + "',nommesa = "+"'"+ txtmesa.Text+ "',puestos ="+txtasientos.Text+", fecha ="+"'"+fechamesa.Text+"', statusmesa ='"+txtestado.Text+"'";
            string tbl = "mesas";
            string id = "id_mesa = '" + mivar + "'";
            cls.Actualizar(up, tbl, id);

            buttEdit.Visible = false;
            cargardatos();
            button1.Visible = true;
        }
    }
}
