﻿namespace ProyectoRestaurante
{
    partial class mantmesas
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
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtmesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbsala = new System.Windows.Forms.ComboBox();
            this.salasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRestauranteDataSet14 = new ProyectoRestaurante.ProyectoRestauranteDataSet14();
            this.salasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRestauranteDataSet1 = new ProyectoRestaurante.ProyectoRestauranteDataSet1();
            this.salasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRestauranteDataSet3 = new ProyectoRestaurante.ProyectoRestauranteDataSet3();
            this.proyectoRestauranteDataSet = new ProyectoRestaurante.ProyectoRestauranteDataSet();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salasTableAdapter = new ProyectoRestaurante.ProyectoRestauranteDataSetTableAdapters.salasTableAdapter();
            this.salasTableAdapter1 = new ProyectoRestaurante.ProyectoRestauranteDataSet1TableAdapters.salasTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.fechamesa = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.txtasientos = new System.Windows.Forms.TextBox();
            this.salasTableAdapter2 = new ProyectoRestaurante.ProyectoRestauranteDataSet3TableAdapters.salasTableAdapter();
            this.buttEdit = new System.Windows.Forms.Button();
            this.salasTableAdapter3 = new ProyectoRestaurante.ProyectoRestauranteDataSet14TableAdapters.salasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(342, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(587, 535);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::ProyectoRestaurante.Properties.Resources.editVer;
            this.Editar.MinimumWidth = 8;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Width = 75;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::ProyectoRestaurante.Properties.Resources.deleRoj;
            this.Eliminar.MinimumWidth = 8;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione la sala";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtmesa
            // 
            this.txtmesa.Location = new System.Drawing.Point(53, 177);
            this.txtmesa.Name = "txtmesa";
            this.txtmesa.Size = new System.Drawing.Size(235, 26);
            this.txtmesa.TabIndex = 13;
            this.txtmesa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre de la mesa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad de asientos";
            // 
            // cbbsala
            // 
            this.cbbsala.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salasBindingSource3, "id_sala", true));
            this.cbbsala.DataSource = this.salasBindingSource3;
            this.cbbsala.DisplayMember = "nomsala";
            this.cbbsala.FormattingEnabled = true;
            this.cbbsala.Location = new System.Drawing.Point(57, 70);
            this.cbbsala.Name = "cbbsala";
            this.cbbsala.Size = new System.Drawing.Size(231, 28);
            this.cbbsala.TabIndex = 18;
            this.cbbsala.ValueMember = "id_sala";
            // 
            // salasBindingSource3
            // 
            this.salasBindingSource3.DataMember = "salas";
            this.salasBindingSource3.DataSource = this.proyectoRestauranteDataSet14;
            // 
            // proyectoRestauranteDataSet14
            // 
            this.proyectoRestauranteDataSet14.DataSetName = "ProyectoRestauranteDataSet14";
            this.proyectoRestauranteDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salasBindingSource1
            // 
            this.salasBindingSource1.DataMember = "salas";
            this.salasBindingSource1.DataSource = this.proyectoRestauranteDataSet1;
            // 
            // proyectoRestauranteDataSet1
            // 
            this.proyectoRestauranteDataSet1.DataSetName = "ProyectoRestauranteDataSet1";
            this.proyectoRestauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salasBindingSource2
            // 
            this.salasBindingSource2.DataMember = "salas";
            this.salasBindingSource2.DataSource = this.proyectoRestauranteDataSet3;
            // 
            // proyectoRestauranteDataSet3
            // 
            this.proyectoRestauranteDataSet3.DataSetName = "ProyectoRestauranteDataSet3";
            this.proyectoRestauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoRestauranteDataSet
            // 
            this.proyectoRestauranteDataSet.DataSetName = "ProyectoRestauranteDataSet";
            this.proyectoRestauranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "salas";
            this.salasBindingSource.DataSource = this.proyectoRestauranteDataSet;
            // 
            // salasTableAdapter
            // 
            this.salasTableAdapter.ClearBeforeFill = true;
            // 
            // salasTableAdapter1
            // 
            this.salasTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha";
            // 
            // fechamesa
            // 
            this.fechamesa.Location = new System.Drawing.Point(57, 367);
            this.fechamesa.Name = "fechamesa";
            this.fechamesa.Size = new System.Drawing.Size(200, 26);
            this.fechamesa.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(61, 460);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(85, 26);
            this.txtestado.TabIndex = 23;
            // 
            // txtasientos
            // 
            this.txtasientos.Location = new System.Drawing.Point(57, 275);
            this.txtasientos.Name = "txtasientos";
            this.txtasientos.Size = new System.Drawing.Size(155, 26);
            this.txtasientos.TabIndex = 24;
            // 
            // salasTableAdapter2
            // 
            this.salasTableAdapter2.ClearBeforeFill = true;
            // 
            // buttEdit
            // 
            this.buttEdit.Location = new System.Drawing.Point(182, 558);
            this.buttEdit.Name = "buttEdit";
            this.buttEdit.Size = new System.Drawing.Size(75, 32);
            this.buttEdit.TabIndex = 25;
            this.buttEdit.Text = "Editar";
            this.buttEdit.UseVisualStyleBackColor = true;
            this.buttEdit.Click += new System.EventHandler(this.buttEdit_Click);
            // 
            // salasTableAdapter3
            // 
            this.salasTableAdapter3.ClearBeforeFill = true;
            // 
            // mantmesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.buttEdit);
            this.Controls.Add(this.txtasientos);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechamesa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbsala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mantmesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.mantmesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRestauranteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtmesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbsala;
        private ProyectoRestauranteDataSet proyectoRestauranteDataSet;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private ProyectoRestauranteDataSetTableAdapters.salasTableAdapter salasTableAdapter;
        private ProyectoRestauranteDataSet1 proyectoRestauranteDataSet1;
        private System.Windows.Forms.BindingSource salasBindingSource1;
        private ProyectoRestauranteDataSet1TableAdapters.salasTableAdapter salasTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechamesa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.TextBox txtasientos;
        private ProyectoRestauranteDataSet3 proyectoRestauranteDataSet3;
        private System.Windows.Forms.BindingSource salasBindingSource2;
        private ProyectoRestauranteDataSet3TableAdapters.salasTableAdapter salasTableAdapter2;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Button buttEdit;
        private ProyectoRestauranteDataSet14 proyectoRestauranteDataSet14;
        private System.Windows.Forms.BindingSource salasBindingSource3;
        private ProyectoRestauranteDataSet14TableAdapters.salasTableAdapter salasTableAdapter3;
    }
}