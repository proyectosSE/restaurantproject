﻿namespace ProyectoRestaurante.consultas
{
    partial class conusua
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtusua = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btbuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // txtusua
            // 
            this.txtusua.Location = new System.Drawing.Point(427, 43);
            this.txtusua.Name = "txtusua";
            this.txtusua.Size = new System.Drawing.Size(338, 26);
            this.txtusua.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(110, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 512);
            this.dataGridView1.TabIndex = 7;
            // 
            // btbuscar
            // 
            this.btbuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btbuscar.IconColor = System.Drawing.Color.Black;
            this.btbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbuscar.Location = new System.Drawing.Point(781, 33);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(107, 47);
            this.btbuscar.TabIndex = 6;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbuscar.UseVisualStyleBackColor = true;
            // 
            // conusua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 644);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusua);
            this.Name = "conusua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusua;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}