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
            this.btsalir = new System.Windows.Forms.Button();
            this.btentrar = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btsalir
            // 
            this.btsalir.Location = new System.Drawing.Point(571, 259);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(130, 36);
            this.btsalir.TabIndex = 12;
            this.btsalir.Text = "Salir";
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click_1);
            // 
            // btentrar
            // 
            this.btentrar.Location = new System.Drawing.Point(406, 259);
            this.btentrar.Name = "btentrar";
            this.btentrar.Size = new System.Drawing.Size(130, 36);
            this.btentrar.TabIndex = 11;
            this.btentrar.Text = "Entrar";
            this.btentrar.UseVisualStyleBackColor = true;
            this.btentrar.Click += new System.EventHandler(this.btentrar_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(406, 196);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(295, 26);
            this.txtpassword.TabIndex = 10;
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(406, 133);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(295, 26);
            this.txtlogin.TabIndex = 9;
            // 
            // login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.btentrar);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtlogin);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.Button btentrar;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtlogin;
    }
}

