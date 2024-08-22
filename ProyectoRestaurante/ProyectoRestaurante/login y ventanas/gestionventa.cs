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

        public string id_mesa;
        public string id_cliente;
        public string totalpago;
        public string fecha;
        public string estado = "I";

        private void btdespachar_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string tabla = "pedidos";
            id_mesa = lblidmesa.Text;
            id_cliente = cbbcliente.SelectedValue.ToString();
            fecha = fechapedido.Text;
            totalpago = monttotal.Text;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                id_pedido = id_pedido + 1;
                var id_producto = fila.Cells["id_producto"].Value.ToString();
                var nomproducto = fila.Cells["dgvproducto"].Value.ToString();
                var cantidad = fila.Cells["dgvcantidad"].Value.ToString();
                var precioprod = fila.Cells["dgvprecio"].Value.ToString();
                var preciototal = fila.Cells["dgvtotal"].Value.ToString();

                string consulta = ""+id_pedido+", "+id_mesa+", "+id_cliente+", "+id_producto+", '"+nomproducto+"', "+cantidad+", "+precioprod+", "+preciototal+", "+totalpago+", '"+fecha+"', '"+estado+"'";
                cls.Agregar(consulta, tabla);

            }


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
    }
}
