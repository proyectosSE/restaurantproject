using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoRestaurante
{
    internal class Conectar
    {
        private SqlConnection conexion = new SqlConnection("server=ELIASPC;Database=restaurantpj;Integrated Security=true");
        
        public void Agregar()
        {
            conexion.Open();
            conexion.Close();
        }

        public void Actualizar()
        {
            conexion.Open();
            conexion.Close();
        }
    }
}
