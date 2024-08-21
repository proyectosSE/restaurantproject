using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using ProyectoRestaurante.login_y_ventanas;
using System.IO;
using System.Drawing;

namespace ProyectoRestaurante.clases
{
    public class DBproductos
    {
        private int id_producto;
        private string producto;
        private decimal precio_venta;
        private byte[] imagen;

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Producto { get => producto; set => producto = value; }
        public decimal Precio_venta { get => precio_venta; set => precio_venta = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }

        SqlConnection conexion = new SqlConnection(rutadb.conexion);

        public void LlenarProductos(FlowLayoutPanel Contenedor, string consulta)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand(consulta,conexion);
            comando.CommandType = System.Data.CommandType.Text;
            SqlDataReader rd = comando.ExecuteReader();

            while(rd.Read())
            {
                Id_producto = Convert.ToInt32(rd[0]);
                producto = Convert.ToString(rd[1]);
                precio_venta = Convert.ToDecimal(rd[5]);
                imagen = ((byte[])rd[11]);

                productos prod = new productos();

                prod.Id = Id_producto;
                prod.Producto = producto;
                prod.Precio = precio_venta.ToString();

                MemoryStream ms = new MemoryStream(imagen);
                prod.ImagenProd = Image.FromStream(ms);

                Contenedor.Controls.Add(prod);
            }
            conexion.Close();
            conexion.Dispose();

        }
    }
}
