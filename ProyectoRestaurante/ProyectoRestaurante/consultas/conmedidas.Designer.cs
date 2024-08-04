namespace ProyectoRestaurante.consultas
{
    partial class conmedidas
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
            this.btbuscar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmedi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(103, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 512);
            this.dataGridView1.TabIndex = 0;
            // 
            // btbuscar
            // 
            this.btbuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btbuscar.IconColor = System.Drawing.Color.Black;
            this.btbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbuscar.Location = new System.Drawing.Point(787, 35);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(107, 47);
            this.btbuscar.TabIndex = 6;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medida";
            // 
            // txtmedi
            // 
            this.txtmedi.Location = new System.Drawing.Point(433, 45);
            this.txtmedi.Name = "txtmedi";
            this.txtmedi.Size = new System.Drawing.Size(338, 26);
            this.txtmedi.TabIndex = 4;
            // 
            // conmedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 644);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmedi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "conmedidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Medidas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmedi;
    }
}