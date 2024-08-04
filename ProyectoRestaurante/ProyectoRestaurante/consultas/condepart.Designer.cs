namespace ProyectoRestaurante
{
    partial class condepart
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
            this.iddepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprovinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRestauranteDataSet12 = new ProyectoRestaurante.ProyectoRestauranteDataSet12();
            this.departamentosTableAdapter = new ProyectoRestaurante.ProyectoRestauranteDataSet12TableAdapters.departamentosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddepartamentoDataGridViewTextBoxColumn,
            this.departamentoDataGridViewTextBoxColumn,
            this.idprovinciaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departamentosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(396, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(527, 576);
            this.dataGridView1.TabIndex = 0;
            // 
            // iddepartamentoDataGridViewTextBoxColumn
            // 
            this.iddepartamentoDataGridViewTextBoxColumn.DataPropertyName = "id_departamento";
            this.iddepartamentoDataGridViewTextBoxColumn.HeaderText = "id_departamento";
            this.iddepartamentoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iddepartamentoDataGridViewTextBoxColumn.Name = "iddepartamentoDataGridViewTextBoxColumn";
            this.iddepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddepartamentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // departamentoDataGridViewTextBoxColumn
            // 
            this.departamentoDataGridViewTextBoxColumn.DataPropertyName = "departamento";
            this.departamentoDataGridViewTextBoxColumn.HeaderText = "departamento";
            this.departamentoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
            this.departamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.departamentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // idprovinciaDataGridViewTextBoxColumn
            // 
            this.idprovinciaDataGridViewTextBoxColumn.DataPropertyName = "id_provincia";
            this.idprovinciaDataGridViewTextBoxColumn.HeaderText = "id_provincia";
            this.idprovinciaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idprovinciaDataGridViewTextBoxColumn.Name = "idprovinciaDataGridViewTextBoxColumn";
            this.idprovinciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idprovinciaDataGridViewTextBoxColumn.Width = 150;
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "departamentos";
            this.departamentosBindingSource.DataSource = this.proyectoRestauranteDataSet12;
            // 
            // proyectoRestauranteDataSet12
            // 
            this.proyectoRestauranteDataSet12.DataSetName = "ProyectoRestauranteDataSet12";
            this.proyectoRestauranteDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // condepart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 644);
            this.Controls.Add(this.dataGridView1);
            this.Name = "condepart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Departamentos";
            this.Load += new System.EventHandler(this.condepart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProyectoRestauranteDataSet12 proyectoRestauranteDataSet12;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private ProyectoRestauranteDataSet12TableAdapters.departamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprovinciaDataGridViewTextBoxColumn;
    }
}