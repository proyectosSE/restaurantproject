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
            this.textNomb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textApell = new System.Windows.Forms.TextBox();
            this.textDirec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textLimcre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttAgregar = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
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
            // textNomb
            // 
            this.textNomb.Location = new System.Drawing.Point(76, 98);
            this.textNomb.Name = "textNomb";
            this.textNomb.Size = new System.Drawing.Size(133, 26);
            this.textNomb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // textApell
            // 
            this.textApell.Location = new System.Drawing.Point(76, 215);
            this.textApell.Name = "textApell";
            this.textApell.Size = new System.Drawing.Size(133, 26);
            this.textApell.TabIndex = 3;
            // 
            // textDirec
            // 
            this.textDirec.Location = new System.Drawing.Point(76, 354);
            this.textDirec.Name = "textDirec";
            this.textDirec.Size = new System.Drawing.Size(133, 26);
            this.textDirec.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de ingreso";
            // 
            // textLimcre
            // 
            this.textLimcre.Location = new System.Drawing.Point(439, 215);
            this.textLimcre.Name = "textLimcre";
            this.textLimcre.Size = new System.Drawing.Size(133, 26);
            this.textLimcre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Limite de credito";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(439, 98);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(133, 26);
            this.textEmail.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // buttAgregar
            // 
            this.buttAgregar.Location = new System.Drawing.Point(76, 475);
            this.buttAgregar.Name = "buttAgregar";
            this.buttAgregar.Size = new System.Drawing.Size(133, 55);
            this.buttAgregar.TabIndex = 12;
            this.buttAgregar.Text = "Agregar";
            this.buttAgregar.UseVisualStyleBackColor = true;
            this.buttAgregar.Click += new System.EventHandler(this.buttAgregar_Click);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(439, 354);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(219, 26);
            this.dateTime.TabIndex = 13;
            this.dateTime.Value = new System.DateTime(2024, 8, 3, 10, 29, 11, 0);
            // 
            // mantcli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.buttAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textLimcre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDirec);
            this.Controls.Add(this.textApell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNomb);
            this.Controls.Add(this.label1);
            this.Name = "mantcli";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNomb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textApell;
        private System.Windows.Forms.TextBox textDirec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLimcre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttAgregar;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}