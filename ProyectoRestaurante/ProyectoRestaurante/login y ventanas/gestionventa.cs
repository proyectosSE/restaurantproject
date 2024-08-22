using ProyectoRestaurante.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ProyectoRestaurante.login_y_ventanas
{
    public partial class gestionventa : Form
    {
        public gestionventa()
        {
            InitializeComponent();
            ocultarcolumna();
            fechapedido.Format = DateTimePickerFormat.Short;
        }

        private string consulta;
        private string consulta2;

        private void llenarmesas ()
        {
            try
            {
                consulta = $"SELECT * FROM mesas WHERE id_sala = {comboBox1.SelectedValue}";
                SqlConnection conexion = new SqlConnection(rutadb.conexion);
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter ad = new SqlDataAdapter(comando);

                DataTable dt = new DataTable();
                ad.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    addmesa(item["id_mesa"].ToString(), item["nommesa"].ToString(), item["puestos"].ToString());

                }
            }
            catch (Exception ex)
            {

            }

        }

        private void addproductos(string id, string nombre,string precio, Image foto)
        {
            var w = new productos
            {
                Producto = nombre,
                Precio = precio,
                ImagenProd = foto,
                Id= Convert.ToInt32(id)
            };

            flowLayoutPanel2.Controls.Add(w);

            w.seleccion += (ss, ee) =>
            {
                var wdgv = (productos)ss;

                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (Convert.ToUInt32(item.Cells["id_producto"].Value) == wdgv.Id)
                    {
                        item.Cells["dgvcantidad"].Value = int.Parse(item.Cells["dgvcantidad"].Value.ToString()) + 1;
                        item.Cells["dgvtotal"].Value = int.Parse(item.Cells["dgvcantidad"].Value.ToString()) * double.Parse(item.Cells["dgvprecio"].Value.ToString());

                        return;
                    }
                    
                }
                dataGridView1.Rows.Add(new object[] { wdgv.Id, wdgv.Producto, 1,wdgv.Precio, wdgv.Precio });
                pagototal();
            };

        }

        private void addmesa(string id, string nommesa, string asientos)
        {
            var w = new mesas
            {
                Mesa = nommesa,
                Asientos = asientos,
                Id = Convert.ToInt32(id)
            };

            flowLayoutPanel1.Controls.Add(w);

            w.seleccion += (ss, ee) =>
            {
                var wmesa = (mesas)ss;

                lbmesa.Text = wmesa.Mesa.ToString();
                lblidmesa.Text = wmesa.Id.ToString();

                RecargarDGV();

            };
            

        }

        private void llenarproductos()
        {
            try
            {
                consulta2 = $"SELECT * FROM productos WHERE id_categoria = {cbbcat.SelectedValue}";
                SqlConnection conexion = new SqlConnection(rutadb.conexion);
                SqlCommand comando = new SqlCommand(consulta2, conexion);
                SqlDataAdapter ad = new SqlDataAdapter(comando);

                DataTable dt = new DataTable();
                ad.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    Byte[] fotoarray = (byte[])item["imagen"];
                    byte[] fotobyte = fotoarray;

                    addproductos(item["id_producto"].ToString(), item["producto"].ToString(), item["precioventa"].ToString(), Image.FromStream(new MemoryStream(fotobyte)));
                }
            }
            catch (Exception ex)
            {

            }

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = flowLayoutPanel1.Controls.Count - 1; i >= 0; i--)
            {
                Control control = flowLayoutPanel1.Controls[i];
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose(); 
            }

            consulta = $"SELECT * FROM mesas WHERE id_sala = {comboBox1.SelectedValue}";
            llenarmesas();              
                        
        }

        private void cbbcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = flowLayoutPanel2.Controls.Count - 1; i >= 0; i--)
            {
                Control control = flowLayoutPanel2.Controls[i];
                flowLayoutPanel2.Controls.Remove(control);
                control.Dispose();
            }

            consulta2 = $"SELECT * FROM productos WHERE id_categoria = {cbbcat.SelectedValue}";
            llenarproductos();
        }

        private void gestionventa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet31.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.proyectoRestauranteDataSet31.clientes);
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet28.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.proyectoRestauranteDataSet28.categorias);
            // TODO: esta línea de código carga datos en la tabla 'proyectoRestauranteDataSet27.salas' Puede moverla o quitarla según sea necesario.
            this.salasTableAdapter1.Fill(this.proyectoRestauranteDataSet27.salas);

            flowLayoutPanel2.Controls.Clear();
            llenarproductos();
            llenarmesas();
        }

        private void ocultarcolumna()
        {
            if (dataGridView1.Columns.Contains("id_producto")) dataGridView1.Columns["id_producto"].Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
            pagototal();
        }

        public void pagototal()
        {
            double total = 0;
            monttotal.Text = "";

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                total += double.Parse(item.Cells["dgvtotal"].Value.ToString());
            }
            monttotal.Text = total.ToString("N2");
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            pagototal();
        }
        public int id_pedido;

        public int id_mesa;
        public int id_cliente;
        public decimal totalpago;
        public string fecha;
        public string estado = "I";

        private void btdespachar_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            Form1 f = new Form1();
            f.lbcliente.Text = cbbcliente.Text;
            f.lbtotal.Text = monttotal.Text;
            f.lbfecha.Text = fechapedido.Text;
            f.lbmesa.Text = lbmesa.Text;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // Evitar filas vacías
                {
                    int rowIndex = f.dataGridView1.Rows.Add();
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        f.dataGridView1.Rows[rowIndex].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }
            f.ShowDialog();
            string tabla = "pedidos";
            id_mesa = int.Parse(lblidmesa.Text);
            id_cliente = int.Parse(cbbcliente.SelectedValue.ToString());
            fecha = fechapedido.Text;
            totalpago = decimal.Parse(monttotal.Text);


            if (dataGridView1.Rows.Count > 0)
            {


                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    //id_pedido = id_pedido + 1;
                    int id_producto = int.Parse(fila.Cells["id_producto"].Value.ToString());
                    string nomproducto = fila.Cells["dgvproducto"].Value.ToString();
                    int cantidad = int.Parse(fila.Cells["dgvcantidad"].Value.ToString());
                    decimal precioprod = decimal.Parse(fila.Cells["dgvprecio"].Value.ToString());
                    decimal preciototal = decimal.Parse(fila.Cells["dgvtotal"].Value.ToString());

                    string consulta = "" + id_mesa + ", " + id_cliente + ", " + id_producto + ", '" + nomproducto + "', " + cantidad + ", " + precioprod + ", " + preciototal + ", " + totalpago + ", '" + fecha + "', '" + estado + "'";
                    cls.AgregarProd(consulta, tabla);

                }
            }
            else
            {
                mensaje msg = new mensaje("error", "Ningún producto seleccionado");
                msg.ShowDialog();
            }
            mensaje ms = new mensaje("listo", "Datos guardados correctamente");
            ms.ShowDialog();


        }

        private void btestado_CheckedChanged(object sender, EventArgs e)
        {
            if (btestado.Checked)
            {
                estado = "A";
            }
            else
            {
                estado = "I";
            }
        }
        public int idprod = 0;

        public void RecargarDGV()
        {

            dataGridView1.Rows.Clear();
            
            string cons = $"SELECT id_producto, nomproducto, cantidad, precioprod, preciototal, id_cliente FROM pedidos WHERE id_mesa= {lblidmesa.Text}";
            try
            {
                using (SqlConnection conexion = new SqlConnection(rutadb.conexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(cons,conexion);
                    SqlDataReader lect = comando.ExecuteReader();


                    while (lect.Read())
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridView1);

                        fila.Cells[0].Value = lect["id_producto"].ToString();
                        fila.Cells[1].Value = lect["nomproducto"].ToString();
                        fila.Cells[2].Value = lect["cantidad"].ToString();
                        fila.Cells[3].Value = lect["precioprod"].ToString();
                        fila.Cells[4].Value = lect["preciototal"].ToString();

                        dataGridView1.Rows.Add(fila);
                    }

                }
                
            }
            catch (Exception ex)
            {

            }
        }
    }
}
