namespace ProyectoRestaurante.login_y_ventanas
{
    partial class gestionventa
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
            this.components = new System.ComponentModel.Container();
            this.contenedor = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btcerrar = new System.Windows.Forms.PictureBox();
            this.proyectoRestauranteDataSet26 = new ProyectoRestaurante.ProyectoRestauranteDataSet26();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salasTableAdapter = new ProyectoRestaurante.ProyectoRestauranteDataSet26TableAdapters.salasTableAdapter();
            this.contenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.flowLayoutPanel1);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contenedor.Location = new System.Drawing.Point(0, 80);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1067, 540);
            this.contenedor.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1061, 540);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btcerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 80);
            this.panel1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salasBindingSource, "id_sala", true));
            this.comboBox1.DataSource = this.salasBindingSource;
            this.comboBox1.DisplayMember = "nomsala";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(523, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "id_sala";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(395, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Salas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(72, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Monitor de mesas";
            // 
            // btcerrar
            // 
            this.btcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcerrar.Image = global::ProyectoRestaurante.Properties.Resources.icons8_close_window_32;
            this.btcerrar.Location = new System.Drawing.Point(1023, 12);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(32, 32);
            this.btcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btcerrar.TabIndex = 8;
            this.btcerrar.TabStop = false;
            // 
            // proyectoRestauranteDataSet26
            // 
            this.proyectoRestauranteDataSet26.DataSetName = "ProyectoRestauranteDataSet26";
            this.proyectoRestauranteDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "salas";
            this.salasBindingSource.DataSource = this.proyectoRestauranteDataSet26;
            // 
            // salasTableAdapter
            // 
            this.salasTableAdapter.ClearBeforeFill = true;
            // 
            // gestionventa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestionventa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.gestionventa_Load);
            this.contenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btcerrar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private ProyectoRestauranteDataSet26 proyectoRestauranteDataSet26;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private ProyectoRestauranteDataSet26TableAdapters.salasTableAdapter salasTableAdapter;
    }
}