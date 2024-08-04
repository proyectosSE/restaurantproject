namespace ProyectoRestaurante
{
    partial class consalas
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
            this.proyectoRestauranteDataSet13 = new ProyectoRestaurante.ProyectoRestauranteDataSet13();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salasTableAdapter = new ProyectoRestaurante.ProyectoRestauranteDataSet13TableAdapters.salasTableAdapter();
            this.idsalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomsalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsalaDataGridViewTextBoxColumn,
            this.nomsalaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(349, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(541, 585);
            this.dataGridView1.TabIndex = 0;
            // 
            // proyectoRestauranteDataSet13
            // 
            this.proyectoRestauranteDataSet13.DataSetName = "ProyectoRestauranteDataSet13";
            this.proyectoRestauranteDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "salas";
            this.salasBindingSource.DataSource = this.proyectoRestauranteDataSet13;
            // 
            // salasTableAdapter
            // 
            this.salasTableAdapter.ClearBeforeFill = true;
            // 
            // idsalaDataGridViewTextBoxColumn
            // 
            this.idsalaDataGridViewTextBoxColumn.DataPropertyName = "id_sala";
            this.idsalaDataGridViewTextBoxColumn.HeaderText = "id_sala";
            this.idsalaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idsalaDataGridViewTextBoxColumn.Name = "idsalaDataGridViewTextBoxColumn";
            this.idsalaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsalaDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomsalaDataGridViewTextBoxColumn
            // 
            this.nomsalaDataGridViewTextBoxColumn.DataPropertyName = "nomsala";
            this.nomsalaDataGridViewTextBoxColumn.HeaderText = "nomsala";
            this.nomsalaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomsalaDataGridViewTextBoxColumn.Name = "nomsalaDataGridViewTextBoxColumn";
            this.nomsalaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomsalaDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 150;
            // 
            // consalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 644);
            this.Controls.Add(this.dataGridView1);
            this.Name = "consalas";
            this.Text = "Consulta Salas";
            this.Load += new System.EventHandler(this.consalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProyectoRestauranteDataSet13 proyectoRestauranteDataSet13;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private ProyectoRestauranteDataSet13TableAdapters.salasTableAdapter salasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomsalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}