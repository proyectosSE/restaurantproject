using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante.clases
{
    internal class verificar
    {
        public static bool campo(Form form)
        {
           
            foreach (Control control in form.Controls)
            {
               
                if (control is TextBox textBox)
                {
                    
                    if (string.IsNullOrEmpty(textBox.Text.Trim()))
                    {
                        textBox.Focus();
                        return true; 
                    }
                }
                                
            }

            return false;
            
        }
    }
}
