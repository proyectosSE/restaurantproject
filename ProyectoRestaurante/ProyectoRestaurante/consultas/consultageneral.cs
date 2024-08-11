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

namespace ProyectoRestaurante.consultas
{
    public partial class consultageneral : Form
    {
        public consultageneral()
        {
            InitializeComponent();
            formatoDGV.FormatearDataGridViews(this);
            ComboBox.Items.AddRange(new object[] { "Clientes", "Mesas", "Salas","Categorias","Usuarios","Departamentos","Medidas","Proveedores","Productos","Monedas","Impuestos" });
            ComboBox.SelectedIndex = 0;
                        
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int indice=1;
        string tabla;
        private void cargardatos(string tabla)
        {

            String consulta = $"SELECT * FROM {tabla} WHERE estado = 'A'";
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
                                               
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }



        private void ComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ComboBox.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    tabla = "clientes";
                    cargardatos(tabla);
                    
                    indice = 1;
                    break;
                case 1:
                    tabla = "mesas";
                    cargardatos(tabla);
                    indice = 2;
                    break;
                case 2:
                    tabla = "salas";
                    cargardatos(tabla);
                    indice = 1;
                    break;
                case 3:
                    tabla = "categorias";
                    cargardatos(tabla);
                    indice = 1;
                    break;
                case 4:
                    tabla = "usuarios";
                    cargardatos(tabla);
                    indice = 1;
                    break;
                case 5:
                    tabla = "departamentos";
                    cargardatos(tabla);
                    indice = 1;
                    break;
                case 6:
                    tabla = "medidas";
                    cargardatos(tabla);
                    indice = 1;
                    break;
                case 7:
                    tabla = "proveedores";
                    cargardatos(tabla);
                    indice = 1;
                    break;
                case 8:
                    tabla = "productos";
                    cargardatos(tabla);
                    indice = 1;
                    break;
                case 9:
                    tabla = "tiposmoneda";
                    cargardatos(tabla);
                    indice = 1;
                    break;
                case 10:
                    tabla = "impuestos";
                    cargardatos(tabla);
                    indice = 1;
                    break;
                default:
                    MessageBox.Show("Ítem desconocido");
                    break;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "estado")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {

                        if (e.Value.ToString() == "A")
                        {
                            this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        }
                    }
                }
            }
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
             string valorABuscar = txtBuscar.Text;
             foreach (DataGridViewRow row in dataGridView1.Rows)
             {
                 if (row.Cells[indice].Value != null &&
                 row.Cells[indice].Value.ToString().Contains(valorABuscar))
                 {
                     dataGridView1.CurrentCell = row.Cells[indice];
                     dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                     break;
                 }
                 else if (row.Cells[indice].Value == null)
                 {
                     MessageBox.Show("Datos no encontrados");
                 }
             }

           
        }
    }
}
