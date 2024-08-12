namespace ProyectoRestaurante.consultas
{
    partial class consultasG
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
            this.ComboBox = new RJCodeAdvance.RJControls.RJComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contenedor = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btcerrar
            // 
            this.btcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcerrar.Image = global::ProyectoRestaurante.Properties.Resources.icons8_close_window_32;
            this.btcerrar.Location = new System.Drawing.Point(1045, 12);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(32, 32);
            this.btcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btcerrar.TabIndex = 3;
            this.btcerrar.TabStop = false;
            this.btcerrar.Click += new System.EventHandler(this.btcerrar_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComboBox.BorderColor = System.Drawing.Color.Gold;
            this.ComboBox.BorderSize = 1;
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox.ForeColor = System.Drawing.Color.Black;
            this.ComboBox.IconColor = System.Drawing.Color.Gold;
            this.ComboBox.ListBackColor = System.Drawing.Color.Gold;
            this.ComboBox.ListTextColor = System.Drawing.Color.Black;
            this.ComboBox.Location = new System.Drawing.Point(525, 18);
            this.ComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.ComboBox.Size = new System.Drawing.Size(225, 32);
            this.ComboBox.TabIndex = 5;
            this.ComboBox.Texts = "";
            this.ComboBox.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_OnSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(105, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consultas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(428, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filtro:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 69);
            this.panel1.TabIndex = 8;
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(4, 69);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1082, 606);
            this.contenedor.TabIndex = 9;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(779, 10);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(75, 50);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // consultasG
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1089, 676);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.btcerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consultasG";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btcerrar;
        private RJCodeAdvance.RJControls.RJComboBox ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.PictureBox PictureBox1;
    }
}