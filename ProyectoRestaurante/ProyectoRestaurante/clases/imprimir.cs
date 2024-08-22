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
    public class imprimir
    {
        private Bitmap memoryImage;

        public void Print(Panel panel)
        {
            CapturePanel(panel);

            using (PrintDocument printDocument = new PrintDocument())
            {
                printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }

        private void CapturePanel(Panel panel)
        {
            // Crear un bitmap con las dimensiones del panel
            memoryImage = new Bitmap(panel.Width, panel.Height);
            // Dibujar el contenido del panel en el bitmap
            panel.DrawToBitmap(memoryImage, new Rectangle(0, 0, panel.Width, panel.Height));
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Dibujar el bitmap en la página a imprimir
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
