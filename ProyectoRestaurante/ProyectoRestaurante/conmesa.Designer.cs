namespace ProyectoRestaurante
{
    partial class conmesa
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
            this.idmesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nommesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusmesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRestauranteDataSet9 = new ProyectoRestaurante.ProyectoRestauranteDataSet9();
            this.mesasTableAdapter = new ProyectoRestaurante.ProyectoRestauranteDataSet9TableAdapters.mesasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmesaDataGridViewTextBoxColumn,
            this.idsalaDataGridViewTextBoxColumn,
            this.nommesaDataGridViewTextBoxColumn,
            this.puestosDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.statusmesaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mesasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(133, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(973, 620);
            this.dataGridView1.TabIndex = 0;
            // 
            // idmesaDataGridViewTextBoxColumn
            // 
            this.idmesaDataGridViewTextBoxColumn.DataPropertyName = "id_mesa";
            this.idmesaDataGridViewTextBoxColumn.HeaderText = "id_mesa";
            this.idmesaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idmesaDataGridViewTextBoxColumn.Name = "idmesaDataGridViewTextBoxColumn";
            this.idmesaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmesaDataGridViewTextBoxColumn.Width = 150;
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
            // nommesaDataGridViewTextBoxColumn
            // 
            this.nommesaDataGridViewTextBoxColumn.DataPropertyName = "nommesa";
            this.nommesaDataGridViewTextBoxColumn.HeaderText = "nommesa";
            this.nommesaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nommesaDataGridViewTextBoxColumn.Name = "nommesaDataGridViewTextBoxColumn";
            this.nommesaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nommesaDataGridViewTextBoxColumn.Width = 150;
            // 
            // puestosDataGridViewTextBoxColumn
            // 
            this.puestosDataGridViewTextBoxColumn.DataPropertyName = "puestos";
            this.puestosDataGridViewTextBoxColumn.HeaderText = "puestos";
            this.puestosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.puestosDataGridViewTextBoxColumn.Name = "puestosDataGridViewTextBoxColumn";
            this.puestosDataGridViewTextBoxColumn.ReadOnly = true;
            this.puestosDataGridViewTextBoxColumn.Width = 150;
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
            // statusmesaDataGridViewTextBoxColumn
            // 
            this.statusmesaDataGridViewTextBoxColumn.DataPropertyName = "statusmesa";
            this.statusmesaDataGridViewTextBoxColumn.HeaderText = "statusmesa";
            this.statusmesaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusmesaDataGridViewTextBoxColumn.Name = "statusmesaDataGridViewTextBoxColumn";
            this.statusmesaDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusmesaDataGridViewTextBoxColumn.Width = 150;
            // 
            // mesasBindingSource
            // 
            this.mesasBindingSource.DataMember = "mesas";
            this.mesasBindingSource.DataSource = this.proyectoRestauranteDataSet9;
            // 
            // proyectoRestauranteDataSet9
            // 
            this.proyectoRestauranteDataSet9.DataSetName = "ProyectoRestauranteDataSet9";
            this.proyectoRestauranteDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesasTableAdapter
            // 
            this.mesasTableAdapter.ClearBeforeFill = true;
            // 
            // conmesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 644);
            this.Controls.Add(this.dataGridView1);
            this.Name = "conmesa";
            this.Text = "Consulta Mesas";
            this.Load += new System.EventHandler(this.conmesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProyectoRestauranteDataSet9 proyectoRestauranteDataSet9;
        private System.Windows.Forms.BindingSource mesasBindingSource;
        private ProyectoRestauranteDataSet9TableAdapters.mesasTableAdapter mesasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nommesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusmesaDataGridViewTextBoxColumn;
    }
}