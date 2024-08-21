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
            this.proyectoRestauranteDataSet26 = new ProyectoRestaurante.ProyectoRestauranteDataSet26();
            this.label2 = new System.Windows.Forms.Label();
            this.btcerrar = new System.Windows.Forms.PictureBox();
            this.salasTableAdapter = new ProyectoRestaurante.ProyectoRestauranteDataSet26TableAdapters.salasTableAdapter();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.proyectoRestauranteDataSet27 = new ProyectoRestaurante.ProyectoRestauranteDataSet27();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salasTableAdapter1 = new ProyectoRestaurante.ProyectoRestauranteDataSet27TableAdapters.salasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbcat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proyectoRestauranteDataSet28 = new ProyectoRestaurante.ProyectoRestauranteDataSet28();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new ProyectoRestaurante.ProyectoRestauranteDataSet28TableAdapters.categoriasTableAdapter();
            this.contenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.dataGridView1);
            this.contenedor.Controls.Add(this.flowLayoutPanel2);
            this.contenedor.Controls.Add(this.flowLayoutPanel1);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contenedor.Location = new System.Drawing.Point(0, 80);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1067, 540);
            this.contenedor.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(189, 540);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbcat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
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
            this.comboBox1.Location = new System.Drawing.Point(12, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "id_sala";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // proyectoRestauranteDataSet26
            // 
            this.proyectoRestauranteDataSet26.DataSetName = "ProyectoRestauranteDataSet26";
            this.proyectoRestauranteDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(54, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Salas:";
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
            // salasTableAdapter
            // 
            this.salasTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(198, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(444, 537);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // proyectoRestauranteDataSet27
            // 
            this.proyectoRestauranteDataSet27.DataSetName = "ProyectoRestauranteDataSet27";
            this.proyectoRestauranteDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "salas";
            this.salasBindingSource.DataSource = this.proyectoRestauranteDataSet27;
            // 
            // salasTableAdapter1
            // 
            this.salasTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(646, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(416, 458);
            this.dataGridView1.TabIndex = 2;
            // 
            // cbbcat
            // 
            this.cbbcat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriasBindingSource, "id_categoria", true));
            this.cbbcat.DataSource = this.categoriasBindingSource;
            this.cbbcat.DisplayMember = "descripcion";
            this.cbbcat.FormattingEnabled = true;
            this.cbbcat.Location = new System.Drawing.Point(314, 39);
            this.cbbcat.Name = "cbbcat";
            this.cbbcat.Size = new System.Drawing.Size(171, 28);
            this.cbbcat.TabIndex = 14;
            this.cbbcat.ValueMember = "id_categoria";
            this.cbbcat.SelectedIndexChanged += new System.EventHandler(this.cbbcat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Categorías:";
            // 
            // proyectoRestauranteDataSet28
            // 
            this.proyectoRestauranteDataSet28.DataSetName = "ProyectoRestauranteDataSet28";
            this.proyectoRestauranteDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this.proyectoRestauranteDataSet28;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btcerrar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private ProyectoRestauranteDataSet26 proyectoRestauranteDataSet26;
        private ProyectoRestauranteDataSet26TableAdapters.salasTableAdapter salasTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ProyectoRestauranteDataSet27 proyectoRestauranteDataSet27;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private ProyectoRestauranteDataSet27TableAdapters.salasTableAdapter salasTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbcat;
        private System.Windows.Forms.Label label1;
        private ProyectoRestauranteDataSet28 proyectoRestauranteDataSet28;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private ProyectoRestauranteDataSet28TableAdapters.categoriasTableAdapter categoriasTableAdapter;
    }
}