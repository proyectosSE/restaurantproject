namespace ProyectoRestaurante
{
    partial class login
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btentrar = new FontAwesome.Sharp.IconButton();
            this.btsalir = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtlogin.Location = new System.Drawing.Point(26, 121);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(264, 26);
            this.txtlogin.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(366, 194);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(264, 26);
            this.txtpassword.TabIndex = 2;
            // 
            // btentrar
            // 
            this.btentrar.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.btentrar.IconColor = System.Drawing.Color.Black;
            this.btentrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btentrar.IconSize = 40;
            this.btentrar.Location = new System.Drawing.Point(366, 275);
            this.btentrar.Name = "btentrar";
            this.btentrar.Size = new System.Drawing.Size(99, 67);
            this.btentrar.TabIndex = 4;
            this.btentrar.UseVisualStyleBackColor = true;
            // 
            // btsalir
            // 
            this.btsalir.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btsalir.IconColor = System.Drawing.Color.Black;
            this.btsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btsalir.IconSize = 40;
            this.btsalir.Location = new System.Drawing.Point(533, 275);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(97, 67);
            this.btsalir.TabIndex = 3;
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoRestaurante.Properties.Resources.interiorismo_restaurantero___interiorismo_restaurantero;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtlogin);
            this.panel1.Location = new System.Drawing.Point(340, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 443);
            this.panel1.TabIndex = 6;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 444);
            this.Controls.Add(this.btentrar);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtpassword;
        private FontAwesome.Sharp.IconButton btsalir;
        private FontAwesome.Sharp.IconButton btentrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

