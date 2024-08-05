namespace ProyectoRestaurante
{
    partial class mantcli
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtapell = new System.Windows.Forms.TextBox();
            this.txtdirec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlimicre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttAgregar = new System.Windows.Forms.Button();
            this.fechain = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(76, 98);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(216, 26);
            this.txtnom.TabIndex = 1;
            this.txtnom.DoubleClick += new System.EventHandler(this.txtnom_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // txtapell
            // 
            this.txtapell.Location = new System.Drawing.Point(76, 186);
            this.txtapell.Name = "txtapell";
            this.txtapell.Size = new System.Drawing.Size(216, 26);
            this.txtapell.TabIndex = 3;
            // 
            // txtdirec
            // 
            this.txtdirec.Location = new System.Drawing.Point(76, 275);
            this.txtdirec.Name = "txtdirec";
            this.txtdirec.Size = new System.Drawing.Size(216, 26);
            this.txtdirec.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de ingreso";
            // 
            // txtlimicre
            // 
            this.txtlimicre.Location = new System.Drawing.Point(354, 186);
            this.txtlimicre.Name = "txtlimicre";
            this.txtlimicre.Size = new System.Drawing.Size(219, 26);
            this.txtlimicre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Limite de credito";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(354, 98);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(219, 26);
            this.txtemail.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // buttAgregar
            // 
            this.buttAgregar.Location = new System.Drawing.Point(76, 365);
            this.buttAgregar.Name = "buttAgregar";
            this.buttAgregar.Size = new System.Drawing.Size(133, 55);
            this.buttAgregar.TabIndex = 12;
            this.buttAgregar.Text = "Agregar";
            this.buttAgregar.UseVisualStyleBackColor = true;
            this.buttAgregar.Click += new System.EventHandler(this.buttAgregar_Click);
            // 
            // fechain
            // 
            this.fechain.Location = new System.Drawing.Point(354, 275);
            this.fechain.Name = "fechain";
            this.fechain.Size = new System.Drawing.Size(219, 26);
            this.fechain.TabIndex = 13;
            this.fechain.Value = new System.DateTime(2024, 8, 3, 10, 29, 11, 0);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 55);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mantcli
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1231, 644);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fechain);
            this.Controls.Add(this.buttAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtlimicre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdirec);
            this.Controls.Add(this.txtapell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label1);
            this.Name = "mantcli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtapell;
        private System.Windows.Forms.TextBox txtdirec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlimicre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttAgregar;
        private System.Windows.Forms.DateTimePicker fechain;
        private System.Windows.Forms.Button button2;
    }
}