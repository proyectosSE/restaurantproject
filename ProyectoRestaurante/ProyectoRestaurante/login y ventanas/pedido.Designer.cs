namespace ProyectoRestaurante.login_y_ventanas
{
    partial class pedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btcerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btcerrar
            // 
            this.btcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcerrar.Image = global::ProyectoRestaurante.Properties.Resources.icons8_close_window_32;
            this.btcerrar.Location = new System.Drawing.Point(956, 12);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(32, 32);
            this.btcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btcerrar.TabIndex = 9;
            this.btcerrar.TabStop = false;
            this.btcerrar.Click += new System.EventHandler(this.btcerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(472, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // pedido
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btcerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(230, 155);
            this.Name = "pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btcerrar;
        private System.Windows.Forms.Label label1;
    }
}