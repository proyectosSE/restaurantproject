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
    public partial class mantdepar : Form
    {
        public mantdepar()
        {
            InitializeComponent();
            cargardatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = "'"+txtdepart.Text+"',"+txtprovincia.Text+"";
            string tabla = "departamentos";
            cls.Agregar(datos, tabla);
        }

        private void cargardatos()
        {
            String consulta = "SELECT * FROM departamentos";
            string connectionString = "server=LAPTOP-ASISTENT;Database=ProyectoRestaurante;Integrated Security=true";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    
                    using (SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;

                        // Configuración de columnas
                        if (dataGridView1.Columns.Contains("id_departamento")) dataGridView1.Columns["id_departamento"].DisplayIndex = 0;
                        if (dataGridView1.Columns.Contains("departamento")) dataGridView1.Columns["departamento"].DisplayIndex = 1;
                        if (dataGridView1.Columns.Contains("id_provincia")) dataGridView1.Columns["id_provincia"].DisplayIndex = 2;
                        if (dataGridView1.Columns.Contains("editar")) dataGridView1.Columns["editar"].DisplayIndex = 3;
                        if (dataGridView1.Columns.Contains("eliminar")) dataGridView1.Columns["eliminar"].DisplayIndex = 4;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }
    }
}
