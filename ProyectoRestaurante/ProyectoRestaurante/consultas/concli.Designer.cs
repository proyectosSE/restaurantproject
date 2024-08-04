namespace ProyectoRestaurante
{
    partial class concli
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
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitecreditoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaingresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRestauranteDataSet10 = new ProyectoRestaurante.ProyectoRestauranteDataSet10();
            this.clientesTableAdapter = new ProyectoRestaurante.ProyectoRestauranteDataSet10TableAdapters.clientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.nomclienteDataGridViewTextBoxColumn,
            this.apellidoclienteDataGridViewTextBoxColumn,
            this.direcclienteDataGridViewTextBoxColumn,
            this.emailclienteDataGridViewTextBoxColumn,
            this.limitecreditoDataGridViewTextBoxColumn,
            this.fechaingresoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 577);
            this.dataGridView1.TabIndex = 0;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomclienteDataGridViewTextBoxColumn
            // 
            this.nomclienteDataGridViewTextBoxColumn.DataPropertyName = "nomcliente";
            this.nomclienteDataGridViewTextBoxColumn.HeaderText = "nomcliente";
            this.nomclienteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomclienteDataGridViewTextBoxColumn.Name = "nomclienteDataGridViewTextBoxColumn";
            this.nomclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomclienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoclienteDataGridViewTextBoxColumn
            // 
            this.apellidoclienteDataGridViewTextBoxColumn.DataPropertyName = "apellidocliente";
            this.apellidoclienteDataGridViewTextBoxColumn.HeaderText = "apellidocliente";
            this.apellidoclienteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidoclienteDataGridViewTextBoxColumn.Name = "apellidoclienteDataGridViewTextBoxColumn";
            this.apellidoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoclienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // direcclienteDataGridViewTextBoxColumn
            // 
            this.direcclienteDataGridViewTextBoxColumn.DataPropertyName = "direccliente";
            this.direcclienteDataGridViewTextBoxColumn.HeaderText = "direccliente";
            this.direcclienteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.direcclienteDataGridViewTextBoxColumn.Name = "direcclienteDataGridViewTextBoxColumn";
            this.direcclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.direcclienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailclienteDataGridViewTextBoxColumn
            // 
            this.emailclienteDataGridViewTextBoxColumn.DataPropertyName = "emailcliente";
            this.emailclienteDataGridViewTextBoxColumn.HeaderText = "emailcliente";
            this.emailclienteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailclienteDataGridViewTextBoxColumn.Name = "emailclienteDataGridViewTextBoxColumn";
            this.emailclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailclienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // limitecreditoDataGridViewTextBoxColumn
            // 
            this.limitecreditoDataGridViewTextBoxColumn.DataPropertyName = "limitecredito";
            this.limitecreditoDataGridViewTextBoxColumn.HeaderText = "limitecredito";
            this.limitecreditoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.limitecreditoDataGridViewTextBoxColumn.Name = "limitecreditoDataGridViewTextBoxColumn";
            this.limitecreditoDataGridViewTextBoxColumn.ReadOnly = true;
            this.limitecreditoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaingresoDataGridViewTextBoxColumn
            // 
            this.fechaingresoDataGridViewTextBoxColumn.DataPropertyName = "fechaingreso";
            this.fechaingresoDataGridViewTextBoxColumn.HeaderText = "fechaingreso";
            this.fechaingresoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaingresoDataGridViewTextBoxColumn.Name = "fechaingresoDataGridViewTextBoxColumn";
            this.fechaingresoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaingresoDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.proyectoRestauranteDataSet10;
            // 
            // proyectoRestauranteDataSet10
            // 
            this.proyectoRestauranteDataSet10.DataSetName = "ProyectoRestauranteDataSet10";
            this.proyectoRestauranteDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // concli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 644);
            this.Controls.Add(this.dataGridView1);
            this.Name = "concli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Clientes";
            this.Load += new System.EventHandler(this.concli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProyectoRestauranteDataSet10 proyectoRestauranteDataSet10;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ProyectoRestauranteDataSet10TableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direcclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitecreditoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaingresoDataGridViewTextBoxColumn;
    }
}