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
            this.txtusua = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.rjToggleButton1 = new RJCodeAdvance.RJControls.RJToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusua
            // 
            this.txtusua.Location = new System.Drawing.Point(12, 12);
            this.txtusua.Name = "txtusua";
            this.txtusua.Size = new System.Drawing.Size(500, 26);
            this.txtusua.TabIndex = 4;
            this.txtusua.TextChanged += new System.EventHandler(this.txtusua_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(977, 541);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(555, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ver inactivos:";
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Location = new System.Drawing.Point(684, 17);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(40, 20);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.White;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.Gold;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.White;
            this.rjToggleButton1.Size = new System.Drawing.Size(40, 21);
            this.rjToggleButton1.TabIndex = 14;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // conusua
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1049, 627);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtusua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conusua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtusua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJToggleButton rjToggleButton1;
    }
}