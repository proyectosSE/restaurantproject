﻿namespace ProyectoRestaurante
{
    partial class mantdepar
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
            this.btagregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtdepart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprovincia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btcerrar = new System.Windows.Forms.PictureBox();
            this.rjToggleButton1 = new RJCodeAdvance.RJControls.RJToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btagregar
            // 
            this.btagregar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregar.Location = new System.Drawing.Point(275, 118);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(112, 32);
            this.btagregar.TabIndex = 11;
            this.btagregar.Text = "Agregar";
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 434);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // txtdepart
            // 
            this.txtdepart.Location = new System.Drawing.Point(53, 52);
            this.txtdepart.Name = "txtdepart";
            this.txtdepart.Size = new System.Drawing.Size(235, 26);
            this.txtdepart.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre de Departamento";
            // 
            // txtprovincia
            // 
            this.txtprovincia.Location = new System.Drawing.Point(376, 52);
            this.txtprovincia.Name = "txtprovincia";
            this.txtprovincia.Size = new System.Drawing.Size(235, 26);
            this.txtprovincia.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(372, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Id de Provincia";
            // 
            // buttEdit
            // 
            this.buttEdit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttEdit.Location = new System.Drawing.Point(421, 118);
            this.buttEdit.Name = "buttEdit";
            this.buttEdit.Size = new System.Drawing.Size(112, 32);
            this.buttEdit.TabIndex = 14;
            this.buttEdit.Text = "Editar";
            this.buttEdit.UseVisualStyleBackColor = true;
            this.buttEdit.Click += new System.EventHandler(this.buttEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(53, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Estado";
            // 
            // btcerrar
            // 
            this.btcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcerrar.Image = global::ProyectoRestaurante.Properties.Resources.icons8_close_window_32;
            this.btcerrar.Location = new System.Drawing.Point(1158, 9);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(32, 32);
            this.btcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btcerrar.TabIndex = 17;
            this.btcerrar.TabStop = false;
            this.btcerrar.Click += new System.EventHandler(this.btcerrar_Click);
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Location = new System.Drawing.Point(57, 134);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(72, 33);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.White;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.Gold;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.White;
            this.rjToggleButton1.Size = new System.Drawing.Size(72, 33);
            this.rjToggleButton1.TabIndex = 18;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // mantdepar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.btcerrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtprovincia);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtdepart);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mantdepar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btcerrar;
        public System.Windows.Forms.TextBox txtdepart;
        public System.Windows.Forms.TextBox txtprovincia;
        private RJCodeAdvance.RJControls.RJToggleButton rjToggleButton1;
    }
}