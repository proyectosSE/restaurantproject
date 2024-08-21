namespace ProyectoRestaurante.login_y_ventanas
{
    partial class mesas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mesanom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cantasientos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.mesanom);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 144);
            this.panel1.TabIndex = 0;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // mesanom
            // 
            this.mesanom.AutoSize = true;
            this.mesanom.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesanom.Location = new System.Drawing.Point(102, 62);
            this.mesanom.Name = "mesanom";
            this.mesanom.Size = new System.Drawing.Size(71, 23);
            this.mesanom.TabIndex = 0;
            this.mesanom.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(60, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asientos";
            // 
            // cantasientos
            // 
            this.cantasientos.AutoSize = true;
            this.cantasientos.Font = new System.Drawing.Font("Cooper Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantasientos.ForeColor = System.Drawing.Color.Black;
            this.cantasientos.Location = new System.Drawing.Point(146, 174);
            this.cantasientos.Name = "cantasientos";
            this.cantasientos.Size = new System.Drawing.Size(26, 19);
            this.cantasientos.TabIndex = 2;
            this.cantasientos.Text = "ca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(60, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "$";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Cooper Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.Black;
            this.total.Location = new System.Drawing.Point(80, 203);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(59, 19);
            this.total.TabIndex = 4;
            this.total.Text = "00000";
            // 
            // mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cantasientos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "mesas";
            this.Size = new System.Drawing.Size(307, 242);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mesanom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cantasientos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total;
    }
}