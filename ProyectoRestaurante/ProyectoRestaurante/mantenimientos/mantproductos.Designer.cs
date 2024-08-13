namespace ProyectoRestaurante.mantenimientos
{
    partial class mantproductos
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
            this.btcerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbcat = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRestauranteDataSet20 = new ProyectoRestaurante.ProyectoRestauranteDataSet20();
            this.cbbproveedor = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRestauranteDataSet21 = new ProyectoRestaurante.ProyectoRestauranteDataSet21();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpreciocomp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpreciovent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btITBIS = new RJCodeAdvance.RJControls.RJToggleButton();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fechaelab = new System.Windows.Forms.DateTimePicker();
            this.btpreparado = new RJCodeAdvance.RJControls.RJToggleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.btfoto = new System.Windows.Forms.Button();
            this.ImagenProducto = new System.Windows.Forms.PictureBox();
            this.btestado = new RJCodeAdvance.RJControls.RJToggleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.btagregar = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.categoriasTableAdapter = new ProyectoRestaurante.ProyectoRestauranteDataSet20TableAdapters.categoriasTableAdapter();
            this.proveedoresTableAdapter = new ProyectoRestaurante.ProyectoRestauranteDataSet21TableAdapters.proveedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btcerrar
            // 
            this.btcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcerrar.Image = global::ProyectoRestaurante.Properties.Resources.icons8_close_window_32;
            this.btcerrar.Location = new System.Drawing.Point(1136, 8);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(32, 32);
            this.btcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btcerrar.TabIndex = 2;
            this.btcerrar.TabStop = false;
            this.btcerrar.Click += new System.EventHandler(this.btcerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(123, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(127, 85);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(175, 26);
            this.txtproducto.TabIndex = 4;
            this.txtproducto.DoubleClick += new System.EventHandler(this.txtproducto_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(123, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoría";
            // 
            // cbbcat
            // 
            this.cbbcat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriasBindingSource, "id_categoria", true));
            this.cbbcat.DataSource = this.categoriasBindingSource;
            this.cbbcat.DisplayMember = "descripcion";
            this.cbbcat.FormattingEnabled = true;
            this.cbbcat.Location = new System.Drawing.Point(127, 167);
            this.cbbcat.Name = "cbbcat";
            this.cbbcat.Size = new System.Drawing.Size(175, 28);
            this.cbbcat.TabIndex = 6;
            this.cbbcat.ValueMember = "id_categoria";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this.proyectoRestauranteDataSet20;
            // 
            // proyectoRestauranteDataSet20
            // 
            this.proyectoRestauranteDataSet20.DataSetName = "ProyectoRestauranteDataSet20";
            this.proyectoRestauranteDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbproveedor
            // 
            this.cbbproveedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proveedoresBindingSource, "id_proveedor", true));
            this.cbbproveedor.DataSource = this.proveedoresBindingSource;
            this.cbbproveedor.DisplayMember = "nomproveedor";
            this.cbbproveedor.FormattingEnabled = true;
            this.cbbproveedor.Location = new System.Drawing.Point(127, 254);
            this.cbbproveedor.Name = "cbbproveedor";
            this.cbbproveedor.Size = new System.Drawing.Size(175, 28);
            this.cbbproveedor.TabIndex = 8;
            this.cbbproveedor.ValueMember = "id_proveedor";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "proveedores";
            this.proveedoresBindingSource.DataSource = this.proyectoRestauranteDataSet21;
            // 
            // proyectoRestauranteDataSet21
            // 
            this.proyectoRestauranteDataSet21.DataSetName = "ProyectoRestauranteDataSet21";
            this.proyectoRestauranteDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(123, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Proveedor";
            // 
            // txtpreciocomp
            // 
            this.txtpreciocomp.Location = new System.Drawing.Point(127, 341);
            this.txtpreciocomp.Name = "txtpreciocomp";
            this.txtpreciocomp.Size = new System.Drawing.Size(175, 26);
            this.txtpreciocomp.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(123, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio de Compra";
            // 
            // txtpreciovent
            // 
            this.txtpreciovent.Location = new System.Drawing.Point(127, 425);
            this.txtpreciovent.Name = "txtpreciovent";
            this.txtpreciovent.Size = new System.Drawing.Size(175, 26);
            this.txtpreciovent.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(123, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio de Venta";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(127, 508);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(175, 26);
            this.txtstock.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(123, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Existencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(394, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "ITBIS";
            // 
            // btITBIS
            // 
            this.btITBIS.AutoSize = true;
            this.btITBIS.Location = new System.Drawing.Point(398, 85);
            this.btITBIS.MinimumSize = new System.Drawing.Size(72, 33);
            this.btITBIS.Name = "btITBIS";
            this.btITBIS.OffBackColor = System.Drawing.Color.Gray;
            this.btITBIS.OffToggleColor = System.Drawing.Color.White;
            this.btITBIS.OnBackColor = System.Drawing.Color.Gold;
            this.btITBIS.OnToggleColor = System.Drawing.Color.White;
            this.btITBIS.Size = new System.Drawing.Size(72, 33);
            this.btITBIS.TabIndex = 20;
            this.btITBIS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btITBIS.UseVisualStyleBackColor = true;
            this.btITBIS.CheckedChanged += new System.EventHandler(this.btITBIS_CheckedChanged);
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(398, 167);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(175, 26);
            this.txtdescuento.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(394, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Descuento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(394, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Fecha de Elaobaración";
            // 
            // fechaelab
            // 
            this.fechaelab.Location = new System.Drawing.Point(398, 256);
            this.fechaelab.Name = "fechaelab";
            this.fechaelab.Size = new System.Drawing.Size(200, 26);
            this.fechaelab.TabIndex = 24;
            // 
            // btpreparado
            // 
            this.btpreparado.AutoSize = true;
            this.btpreparado.Location = new System.Drawing.Point(398, 339);
            this.btpreparado.MinimumSize = new System.Drawing.Size(72, 33);
            this.btpreparado.Name = "btpreparado";
            this.btpreparado.OffBackColor = System.Drawing.Color.Gray;
            this.btpreparado.OffToggleColor = System.Drawing.Color.White;
            this.btpreparado.OnBackColor = System.Drawing.Color.Gold;
            this.btpreparado.OnToggleColor = System.Drawing.Color.White;
            this.btpreparado.Size = new System.Drawing.Size(72, 33);
            this.btpreparado.TabIndex = 26;
            this.btpreparado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btpreparado.UseVisualStyleBackColor = true;
            this.btpreparado.CheckedChanged += new System.EventHandler(this.btpreparado_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(394, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Preparado";
            // 
            // btfoto
            // 
            this.btfoto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfoto.Location = new System.Drawing.Point(680, 332);
            this.btfoto.Name = "btfoto";
            this.btfoto.Size = new System.Drawing.Size(269, 35);
            this.btfoto.TabIndex = 28;
            this.btfoto.Text = "FOTO";
            this.btfoto.UseVisualStyleBackColor = true;
            this.btfoto.Click += new System.EventHandler(this.btfoto_Click);
            // 
            // ImagenProducto
            // 
            this.ImagenProducto.Location = new System.Drawing.Point(680, 58);
            this.ImagenProducto.Name = "ImagenProducto";
            this.ImagenProducto.Size = new System.Drawing.Size(269, 257);
            this.ImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenProducto.TabIndex = 29;
            this.ImagenProducto.TabStop = false;
            // 
            // btestado
            // 
            this.btestado.AutoSize = true;
            this.btestado.Location = new System.Drawing.Point(398, 423);
            this.btestado.MinimumSize = new System.Drawing.Size(72, 33);
            this.btestado.Name = "btestado";
            this.btestado.OffBackColor = System.Drawing.Color.Gray;
            this.btestado.OffToggleColor = System.Drawing.Color.White;
            this.btestado.OnBackColor = System.Drawing.Color.Gold;
            this.btestado.OnToggleColor = System.Drawing.Color.White;
            this.btestado.Size = new System.Drawing.Size(72, 33);
            this.btestado.TabIndex = 31;
            this.btestado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btestado.UseVisualStyleBackColor = true;
            this.btestado.CheckedChanged += new System.EventHandler(this.btestado_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(394, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Estado";
            // 
            // btagregar
            // 
            this.btagregar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregar.Location = new System.Drawing.Point(378, 508);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(107, 38);
            this.btagregar.TabIndex = 32;
            this.btagregar.Text = "Agregar";
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // btedit
            // 
            this.btedit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedit.Location = new System.Drawing.Point(538, 508);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(107, 38);
            this.btedit.TabIndex = 33;
            this.btedit.Text = "Editar";
            this.btedit.UseVisualStyleBackColor = true;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // mantproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.btestado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ImagenProducto);
            this.Controls.Add(this.btfoto);
            this.Controls.Add(this.btpreparado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fechaelab);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btITBIS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpreciovent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpreciocomp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbproveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbcat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btcerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mantproductos";
            this.Text = "mantproductos";
            this.Load += new System.EventHandler(this.mantproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btcerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public RJCodeAdvance.RJControls.RJToggleButton btITBIS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public RJCodeAdvance.RJControls.RJToggleButton btpreparado;
        private System.Windows.Forms.Label label10;
        public RJCodeAdvance.RJControls.RJToggleButton btestado;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtproducto;
        public System.Windows.Forms.ComboBox cbbcat;
        public System.Windows.Forms.ComboBox cbbproveedor;
        public System.Windows.Forms.TextBox txtpreciocomp;
        public System.Windows.Forms.TextBox txtpreciovent;
        public System.Windows.Forms.TextBox txtstock;
        public System.Windows.Forms.TextBox txtdescuento;
        public System.Windows.Forms.DateTimePicker fechaelab;
        public System.Windows.Forms.Button btfoto;
        public System.Windows.Forms.Button btagregar;
        public System.Windows.Forms.Button btedit;
        public System.Windows.Forms.PictureBox ImagenProducto;
        private ProyectoRestauranteDataSet20 proyectoRestauranteDataSet20;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private ProyectoRestauranteDataSet20TableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private ProyectoRestauranteDataSet21 proyectoRestauranteDataSet21;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private ProyectoRestauranteDataSet21TableAdapters.proveedoresTableAdapter proveedoresTableAdapter;
    }
}