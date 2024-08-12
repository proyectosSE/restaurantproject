using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoRestaurante
{
    internal class Conectar
    {
        public static SqlConnection conexion = new SqlConnection(rutadb.conexion);
        
        public void Agregar(string datos, string tabla)
        {
            try
            {
                conexion.Open();
                string cadena = $"INSERT INTO {tabla} VALUES({datos});";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                mensaje ms = new mensaje("listo", "Datos guardados correctamente");
                ms.ShowDialog();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de SQL: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        
        public void Actualizar(string datos,string tabla,string id)
        {
            try
            {
                conexion.Open();
                string cadena = $"UPDATE {tabla} SET {datos} WHERE {id};";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                mensaje ms = new mensaje("listo", "Datos editados correctamente");
                ms.ShowDialog();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de SQL: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
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
