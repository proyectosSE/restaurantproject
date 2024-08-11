using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante.clases
{
    public static class formatoDGV
    {
        public static void FormatearDataGridViews(Form formulario)
        {
            // Recorre todos los controles en el formulario
            foreach (Control control in formulario.Controls)
            {
                // Verifica si el control es un DataGridView
                if (control is DataGridView dataGridView)
                {
                    // Aplica el formato deseado
                    dataGridView.EnableHeadersVisualStyles=false;
                    dataGridView.BackgroundColor = Color.Black; // Color de fondo
                    dataGridView.DefaultCellStyle.ForeColor = Color.Black; // Color del texto
                    dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightBlue; // Color de selección
                    dataGridView.DefaultCellStyle.SelectionForeColor = Color.White; // Color del texto seleccionado                   
                    dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; // Color del texto en los encabezados
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajuste automático de columnas
                    dataGridView.BorderStyle = BorderStyle.FixedSingle; // Estilo de borde
                    dataGridView.GridColor = Color.Black;
                    

                }
            }
        }
    }
}
