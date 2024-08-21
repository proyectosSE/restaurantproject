namespace ProyectoRestaurante.login_y_ventanas
{
    partial class productos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.precioprod = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomprod = new System.Windows.Forms.Label();
            this.prodimagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.prodimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // precioprod
            // 
            this.precioprod.AutoSize = true;
            this.precioprod.Font = new System.Drawing.Font("Cooper Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioprod.ForeColor = System.Drawing.Color.Black;
            this.precioprod.Location = new System.Drawing.Point(39, 177);
            this.precioprod.Name = "precioprod";
            this.precioprod.Size = new System.Drawing.Size(59, 19);
            this.precioprod.TabIndex = 8;
            this.precioprod.Text = "00000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "$";
            // 
            // nomprod
            // 
            this.nomprod.AutoSize = true;
            this.nomprod.Font = new System.Drawing.Font("Cooper Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomprod.ForeColor = System.Drawing.Color.Black;
            this.nomprod.Location = new System.Drawing.Point(15, 154);
            this.nomprod.Name = "nomprod";
            this.nomprod.Size = new System.Drawing.Size(52, 19);
            this.nomprod.TabIndex = 5;
            this.nomprod.Text = "name";
            // 
            // prodimagen
            // 
            this.prodimagen.Location = new System.Drawing.Point(16, 12);
            this.prodimagen.Name = "prodimagen";
            this.prodimagen.Size = new System.Drawing.Size(178, 137);
            this.prodimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prodimagen.TabIndex = 0;
            this.prodimagen.TabStop = false;
            // 
            // productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.precioprod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomprod);
            this.Controls.Add(this.prodimagen);
            this.Name = "productos";
            this.Size = new System.Drawing.Size(210, 210);
            ((System.ComponentModel.ISupportInitialize)(this.prodimagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox prodimagen;
        private System.Windows.Forms.Label precioprod;
        private System.Windows.Forms.Label nomprod;
    }
}
