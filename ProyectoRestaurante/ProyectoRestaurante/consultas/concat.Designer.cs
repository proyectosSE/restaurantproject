namespace ProyectoRestaurante
{
    partial class concat
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
            this.proyectoRestauranteDataSet11 = new ProyectoRestaurante.ProyectoRestauranteDataSet11();
            this.categoriasTableAdapter = new ProyectoRestaurante.ProyectoRestauranteDataSet11TableAdapters.categoriasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtcat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // proyectoRestauranteDataSet11
            // 
            this.proyectoRestauranteDataSet11.DataSetName = "ProyectoRestauranteDataSet11";
            this.proyectoRestauranteDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 512);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtcat
            // 
            this.txtcat.Location = new System.Drawing.Point(434, 49);
            this.txtcat.Name = "txtcat";
            this.txtcat.Size = new System.Drawing.Size(338, 26);
            this.txtcat.TabIndex = 1;
            this.txtcat.TextChanged += new System.EventHandler(this.txtcat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categorías";
            // 
            // concat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1231, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "concat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProyectoRestauranteDataSet11 proyectoRestauranteDataSet11;
        private ProyectoRestauranteDataSet11TableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcat;
        private System.Windows.Forms.Label label1;
    }
}