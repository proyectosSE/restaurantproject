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
            this.btsalir = new FontAwesome.Sharp.IconButton();
            this.btentrar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(470, 190);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(264, 26);
            this.txtlogin.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(470, 250);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(264, 26);
            this.txtpassword.TabIndex = 2;
            // 
            // btsalir
            // 
            this.btsalir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btsalir.IconColor = System.Drawing.Color.Black;
            this.btsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btsalir.Location = new System.Drawing.Point(637, 336);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(131, 35);
            this.btsalir.TabIndex = 3;
            this.btsalir.Text = "Salir";
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // btentrar
            // 
            this.btentrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btentrar.IconColor = System.Drawing.Color.Black;
            this.btentrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btentrar.Location = new System.Drawing.Point(470, 336);
            this.btentrar.Name = "btentrar";
            this.btentrar.Size = new System.Drawing.Size(131, 35);
            this.btentrar.TabIndex = 4;
            this.btentrar.Text = "Entrar";
            this.btentrar.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btentrar);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtlogin);
            this.Name = "login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtpassword;
        private FontAwesome.Sharp.IconButton btsalir;
        private FontAwesome.Sharp.IconButton btentrar;
    }
}

