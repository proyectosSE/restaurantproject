using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoRestaurante.mantenimientos
{
    public partial class dgvprod : Form
    {
        public dgvprod()
        {
            InitializeComponent();
        }

        public void cargadatos()
        {
            string consulta = "SELECT * FROM productos";
            try
            {
                using (SqlConnection conexion = new SqlConnection(rutadb.conexion))
                {
                    conexion.Open();

                    using (SqlDataAdapter ad = new SqlDataAdapter(consulta, conexion))
                    {
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        dataGridView1.DataSource = dt;

                        if (dataGridView1.Columns.Contains("id_productos")) dataGridView1.Columns["id_provincia"].DisplayIndex=0;
                        if (dataGridView1.Columns.Contains("producto")) dataGridView1.Columns["producto"].DisplayIndex = 1;
                        if (dataGridView1.Columns.Contains("id_categoria")) dataGridView1.Columns["id_categoria"].DisplayIndex = 2;
                        if (dataGridView1.Columns.Contains("id_proveedor")) dataGridView1.Columns["id_proveedor"].DisplayIndex = 3;
                        if (dataGridView1.Columns.Contains("preciocompra")) dataGridView1.Columns["preciocompra"].DisplayIndex = 4;
                        if (dataGridView1.Columns.Contains("precioventa")) dataGridView1.Columns["precioventa"].DisplayIndex = 5;
                        if (dataGridView1.Columns.Contains("existencia")) dataGridView1.Columns["existencia"].DisplayIndex = 6;
                        if (dataGridView1.Columns.Contains("itbisproducto")) dataGridView1.Columns["itbisproducto"].DisplayIndex = 7;
                        if (dataGridView1.Columns.Contains("descproducto")) dataGridView1.Columns["descproducto"].DisplayIndex = 8;
                        if (dataGridView1.Columns.Contains("fechaelaboracion")) dataGridView1.Columns["fechaelaboracion"].DisplayIndex = 9;
                        if (dataGridView1.Columns.Contains("preparado")) dataGridView1.Columns["preparado"].DisplayIndex = 10;
                        if (dataGridView1.Columns.Contains("imagen")) dataGridView1.Columns["imagen"].DisplayIndex = 11;
                        if (dataGridView1.Columns.Contains("estado")) dataGridView1.Columns["estado"].DisplayIndex = 12;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos, " + ex);
            }
            
        }
    }
}
