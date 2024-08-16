namespace ProyectoRestaurante
{
    partial class mantmesas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btagregar = new System.Windows.Forms.Button();
            this.txtmesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbsala = new System.Windows.Forms.ComboBox();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRestauranteDataSet22 = new ProyectoRestaurante.ProyectoRestauranteDataSet22();
            this.proyectoRestauranteDataSet16 = new ProyectoRestaurante.ProyectoRestauranteDataSet16();
            this.proyectoRestauranteDataSet19 = new ProyectoRestaurante.ProyectoRestauranteDataSet19();
            this.proyectoRestauranteDataSet14 = new ProyectoRestaurante.ProyectoRestauranteDataSet14();
            this.proyectoRestauranteDataSet1 = new ProyectoRestaurante.ProyectoRestauranteDataSet1();
            this.proyectoRestauranteDataSet3 = new ProyectoRestaurante.ProyectoRestauranteDataSet3();
            this.proyectoRestauranteDataSet = new ProyectoRestaurante.ProyectoRestauranteDataSet();
            this.salasTableAdapter = new ProyectoRestaurante.ProyectoRestauranteDataSetTableAdapters.salasTableAdapter();
            this.salasTableAdapter1 = new ProyectoRestaurante.ProyectoRestauranteDataSet1TableAdapters.salasTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.fechamesa = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtasientos = new System.Windows.Forms.TextBox();
            this.salasTableAdapter2 = new ProyectoRestaurante.ProyectoRestauranteDataSet3TableAdapters.salasTableAdapter();
            this.buttEdit = new System.Windows.Forms.Button();
            this.salasTableAdapter3 = new ProyectoRestaurante.ProyectoRestauranteDataSet14TableAdapters.salasTableAdapter();
            this.salasTableAdapter4 = new ProyectoRestaurante.ProyectoRestauranteDataSet16TableAdapters.salasTableAdapter();
            this.btcerrar = new System.Windows.Forms.PictureBox();
            this.rjToggleButton1 = new RJCodeAdvance.RJControls.RJToggleButton();
            this.salasTableAdapter5 = new ProyectoRestaurante.ProyectoRestauranteDataSet19TableAdapters.salasTableAdapter();
            this.salasTableAdapter6 = new ProyectoRestaurante.ProyectoRestauranteDataSet22TableAdapters.salasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 381);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione la sala";
            // 
            // btagregar
            // 
            this.btagregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btagregar.Location = new System.Drawing.Point(250, 183);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(98, 32);
            this.btagregar.TabIndex = 14;
            this.btagregar.Text = "Agregar";
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // txtmesa
            // 
            this.txtmesa.Location = new System.Drawing.Point(301, 62);
            this.txtmesa.Name = "txtmesa";
            this.txtmesa.Size = new System.Drawing.Size(235, 26);
            this.txtmesa.TabIndex = 13;
            this.txtmesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmesa_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(297, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre de la mesa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(297, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad de asientos";
            // 
            // cbbsala
            // 
            this.cbbsala.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salasBindingSource, "id_sala", true));
            this.cbbsala.DataSource = this.salasBindingSource;
            this.cbbsala.DisplayMember = "nomsala";
            this.cbbsala.FormattingEnabled = true;
            this.cbbsala.Location = new System.Drawing.Point(30, 60);
            this.cbbsala.Name = "cbbsala";
            this.cbbsala.Size = new System.Drawing.Size(231, 28);
            this.cbbsala.TabIndex = 18;
            this.cbbsala.ValueMember = "id_sala";
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "salas";
            this.salasBindingSource.DataSource = this.proyectoRestauranteDataSet22;
            // 
            // proyectoRestauranteDataSet22
            // 
            this.proyectoRestauranteDataSet22.DataSetName = "ProyectoRestauranteDataSet22";
            this.proyectoRestauranteDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoRestauranteDataSet16
            // 
            this.proyectoRestauranteDataSet16.DataSetName = "ProyectoRestauranteDataSet16";
            this.proyectoRestauranteDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoRestauranteDataSet19
            // 
            this.proyectoRestauranteDataSet19.DataSetName = "ProyectoRestauranteDataSet19";
            this.proyectoRestauranteDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoRestauranteDataSet14
            // 
            this.proyectoRestauranteDataSet14.DataSetName = "ProyectoRestauranteDataSet14";
            this.proyectoRestauranteDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoRestauranteDataSet1
            // 
            this.proyectoRestauranteDataSet1.DataSetName = "ProyectoRestauranteDataSet1";
            this.proyectoRestauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoRestauranteDataSet3
            // 
            this.proyectoRestauranteDataSet3.DataSetName = "ProyectoRestauranteDataSet3";
            this.proyectoRestauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoRestauranteDataSet
            // 
            this.proyectoRestauranteDataSet.DataSetName = "ProyectoRestauranteDataSet";
            this.proyectoRestauranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salasTableAdapter
            // 
            this.salasTableAdapter.ClearBeforeFill = true;
            // 
            // salasTableAdapter1
            // 
            this.salasTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(30, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha";
            // 
            // fechamesa
            // 
            this.fechamesa.Location = new System.Drawing.Point(34, 134);
            this.fechamesa.Name = "fechamesa";
            this.fechamesa.Size = new System.Drawing.Size(200, 26);
            this.fechamesa.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(582, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Estado";
            // 
            // txtasientos
            // 
            this.txtasientos.Location = new System.Drawing.Point(301, 136);
            this.txtasientos.Name = "txtasientos";
            this.txtasientos.Size = new System.Drawing.Size(82, 26);
            this.txtasientos.TabIndex = 24;
            // 
            // salasTableAdapter2
            // 
            this.salasTableAdapter2.ClearBeforeFill = true;
            // 
            // buttEdit
            // 
            this.buttEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttEdit.Location = new System.Drawing.Point(372, 183);
            this.buttEdit.Name = "buttEdit";
            this.buttEdit.Size = new System.Drawing.Size(96, 32);
            this.buttEdit.TabIndex = 25;
            this.buttEdit.Text = "Editar";
            this.buttEdit.UseVisualStyleBackColor = true;
            this.buttEdit.Click += new System.EventHandler(this.buttEdit_Click);
            // 
            // salasTableAdapter3
            // 
            this.salasTableAdapter3.ClearBeforeFill = true;
            // 
            // salasTableAdapter4
            // 
            this.salasTableAdapter4.ClearBeforeFill = true;
            // 
            // btcerrar
            // 
            this.btcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcerrar.Image = global::ProyectoRestaurante.Properties.Resources.icons8_close_window_32;
            this.btcerrar.Location = new System.Drawing.Point(1160, 7);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(32, 32);
            this.btcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btcerrar.TabIndex = 27;
            this.btcerrar.TabStop = false;
            this.btcerrar.Click += new System.EventHandler(this.btcerrar_Click_1);
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Location = new System.Drawing.Point(586, 65);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(72, 33);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.White;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.Gold;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.White;
            this.rjToggleButton1.Size = new System.Drawing.Size(72, 33);
            this.rjToggleButton1.TabIndex = 28;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // salasTableAdapter5
            // 
            this.salasTableAdapter5.ClearBeforeFill = true;
            // 
            // salasTableAdapter6
            // 
            this.salasTableAdapter6.ClearBeforeFill = true;
            // 
            // mantmesas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.btcerrar);
            this.Controls.Add(this.buttEdit);
            this.Controls.Add(this.txtasientos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechamesa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbsala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.txtmesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mantmesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.mantmesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ProyectoRestauranteDataSet proyectoRestauranteDataSet;
        private ProyectoRestauranteDataSetTableAdapters.salasTableAdapter salasTableAdapter;
        private ProyectoRestauranteDataSet1 proyectoRestauranteDataSet1;
        private ProyectoRestauranteDataSet1TableAdapters.salasTableAdapter salasTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ProyectoRestauranteDataSet3 proyectoRestauranteDataSet3;
        private ProyectoRestauranteDataSet3TableAdapters.salasTableAdapter salasTableAdapter2;
        private System.Windows.Forms.Button buttEdit;
        private ProyectoRestauranteDataSet14 proyectoRestauranteDataSet14;
        private ProyectoRestauranteDataSet14TableAdapters.salasTableAdapter salasTableAdapter3;
        private ProyectoRestauranteDataSet16 proyectoRestauranteDataSet16;
        private ProyectoRestauranteDataSet16TableAdapters.salasTableAdapter salasTableAdapter4;
        private System.Windows.Forms.PictureBox btcerrar;
        public System.Windows.Forms.TextBox txtmesa;
        public System.Windows.Forms.ComboBox cbbsala;
        public System.Windows.Forms.DateTimePicker fechamesa;
        public System.Windows.Forms.TextBox txtasientos;
        private RJCodeAdvance.RJControls.RJToggleButton rjToggleButton1;
        private ProyectoRestauranteDataSet19 proyectoRestauranteDataSet19;
        private ProyectoRestauranteDataSet19TableAdapters.salasTableAdapter salasTableAdapter5;
        private ProyectoRestauranteDataSet22 proyectoRestauranteDataSet22;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private ProyectoRestauranteDataSet22TableAdapters.salasTableAdapter salasTableAdapter6;
    }
}