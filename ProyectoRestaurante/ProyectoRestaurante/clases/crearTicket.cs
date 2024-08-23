using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante.clases
{
    public class crearTicket
    {
        public string cliente { get; set; }
        public string mesa { get; set; }
        public string fecha { get; set; }
        public Image logo { get; set; }

        public decimal total { get; set; }

        public List<productos2> listaProductos = new List<productos2>();


        private PrintDocument doc = new PrintDocument();
        private PrintPreviewDialog vista = new PrintPreviewDialog();

        public void imprimir(crearTicket p)
        {
            //doc.PrinterSettings.PrinterName = doc.DefaultPageSettings.PrinterSettings.PrinterName;
            //doc.PrintPage += new PrintPageEventHandler(imprimeticket);
            //vista.Document = doc;
            //vista.Show();
            //doc.Print();

            PrintDocument doc = new PrintDocument();
            // Establece la impresora como "Microsoft Print to PDF"
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            // Genera el nombre del archivo con la fecha actual
            string fechaActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string rutaArchivo = $@"C:\Users\LIKELIAS\Desktop\Clases 2-2024\Ejemplo_P3\ProyectoRestaurante\pdf\factura_{fechaActual}.pdf";

            // Define la ruta y el nombre del archivo PDF
            doc.PrinterSettings.PrintFileName = rutaArchivo;
            doc.PrinterSettings.PrintToFile = true;

            // Asocia el evento PrintPage con el manejador de eventos
            doc.PrintPage += new PrintPageEventHandler(imprimeticket);

            // Realiza la impresión (que generará el archivo PDF en la ruta especificada)
            doc.Print();

        }

        public void imprimeticket(object sender, PrintPageEventArgs e)
        {
            int posX, posY;
            Font fuente = new Font("consola", 15, FontStyle.Bold);
            try
            {
                posX = 10;
                posY = 10;
                e.Graphics.DrawImage(logo, 15, 20, 100, 100);
                posY += 115;
                e.Graphics.DrawString($"Cliente: {cliente}", fuente, Brushes.Black, posX, posY);
                posY += 25;
                e.Graphics.DrawString($"Mesa: {mesa}", fuente, Brushes.Black, posX, posY);
                posY += 25;
                e.Graphics.DrawString($"Fecha: {fecha}", fuente, Brushes.Black, posX, posY);
                posY += 45;

                e.Graphics.DrawString("-----------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString("producto               cant        precio        subtotal", fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString("-----------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 30;

                fuente = new Font("consola", 13, FontStyle.Bold);
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    e.Graphics.DrawString(listaProductos[i].producto + espaciar(listaProductos[i].cantidad.ToString().Length, 24) + listaProductos[i].cantidad + espaciar(listaProductos[i].precio.ToString().Length, 12) + listaProductos[i].precio + espaciar(listaProductos[i].total.ToString().Length, 14) + listaProductos[i].total, fuente, Brushes.Black, posX, posY);
                    posY += 15;
                }

                fuente = new Font("consola", 15, FontStyle.Bold);
                e.Graphics.DrawString("-----------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 30;
                e.Graphics.DrawString($"Total: {total}", fuente, Brushes.Black, posX, posY);
                posY += 50;
                e.Graphics.DrawString("Gracias por su compra>>>>>", fuente, Brushes.Black, posX, posY);
                posY += 25;
                e.Graphics.DrawString("<<<<<<FRETUFINA>>>>>", fuente, Brushes.Black, posX, posY);
                posY += 25;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public string espaciar(int tamaño, int valor)
        {
            string espacio = "";
            int subvalor = 0;
            subvalor = valor - tamaño;

            for (int i = 0; i < subvalor; i++)
            {
                espacio = espacio + " ";
            }
            return espacio;

        }
    }
}
