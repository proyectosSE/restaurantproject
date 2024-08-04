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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proyectoRestauranteDataSet13 = new ProyectoRestaurante.ProyectoRestauranteDataSet13();
            this.salasTableAdapter = new ProyectoRestaurante.ProyectoRestauranteDataSet13TableAdapters.salasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsala = new System.Windows.Forms.TextBox();
            this.btbuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 512);
            this.dataGridView1.TabIndex = 0;
            // 
            // proyectoRestauranteDataSet13
            // 
            this.proyectoRestauranteDataSet13.DataSetName = "ProyectoRestauranteDataSet13";
            this.proyectoRestauranteDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salasTableAdapter
            // 
            this.salasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sala";
            // 
            // txtsala
            // 
            this.txtsala.Location = new System.Drawing.Point(412, 40);
            this.txtsala.Name = "txtsala";
            this.txtsala.Size = new System.Drawing.Size(338, 26);
            this.txtsala.TabIndex = 2;
            // 
            // btbuscar
            // 
            this.btbuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btbuscar.IconColor = System.Drawing.Color.Black;
            this.btbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbuscar.Location = new System.Drawing.Point(767, 30);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(107, 47);
            this.btbuscar.TabIndex = 3;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbuscar.UseVisualStyleBackColor = true;
            // 
            // consalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 644);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.txtsala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "consalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Salas";
            this.Load += new System.EventHandler(this.consalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProyectoRestauranteDataSet13 proyectoRestauranteDataSet13;
        private ProyectoRestauranteDataSet13TableAdapters.salasTableAdapter salasTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsala;
        private FontAwesome.Sharp.IconButton btbuscar;
    }
}