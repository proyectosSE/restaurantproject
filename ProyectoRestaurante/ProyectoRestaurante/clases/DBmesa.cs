using ProyectoRestaurante.login_y_ventanas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante.clases
{
    public class DBmesa
    {
        private int id_mesa;
        private string nommesa;
        private string cantasientos;
        private string total;

        public int Id_mesa { get => id_mesa; set => id_mesa = value; }
        public string Nommesa { get => nommesa; set => nommesa = value; }
        public string Cantasientos { get => cantasientos; set => cantasientos = value; }
        public string Total { get => total; set => total = value; }

        SqlConnection conexion = new SqlConnection(rutadb.conexion);

        public void Llenarbotones(FlowLayoutPanel contenedor,string consulta)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                id_mesa = Convert.ToInt32(reader[0]);
                nommesa = reader[2].ToString();
                cantasientos = reader[3].ToString();
                

                mesas btn = new mesas();
                btn.Id = id_mesa;
                btn.Mesa = nommesa;
                btn.Asientos = cantasientos;


                contenedor.Controls.Add(btn);
            }

            conexion.Close(); 
            conexion.Dispose();
            
        }

    }
}
