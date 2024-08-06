using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace ProyectoRestaurante
{
    internal class Conectar
    {
        public static SqlConnection conexion = new SqlConnection(rutadb.conexion);
        
        public void Agregar(string datos, string tabla)
        {
            conexion.Open();
            string cadena = $"INSERT INTO {tabla} VALUES({datos});";
            SqlCommand comando = new SqlCommand(cadena,conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos guardados");
            conexion.Close();
        }

        
        public void Actualizar(string datos,string tabla,string id)
        {
            conexion.Open();
            string cadena = $"UPDATE {tabla} SET {datos} WHERE {id};";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos editados");
            conexion.Close();
        }

        public void eliminar (string tabla, string id)
        {
            conexion.Open();
            string cadena = $"DELETE FROM {tabla} WHERE {id};";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Elimando correctamente");
            conexion.Close();
        }
           
    }
}
