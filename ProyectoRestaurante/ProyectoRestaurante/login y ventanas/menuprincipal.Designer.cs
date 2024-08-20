namespace ProyectoRestaurante
{
    partial class menuprincipal
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
            this.panelbtns = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contenedor = new System.Windows.Forms.Panel();
            this.btminimizar = new System.Windows.Forms.PictureBox();
            this.btcerrar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btconsulta = new System.Windows.Forms.Button();
            this.btmantenimiento = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelbtns.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbtns
            // 
            this.panelbtns.BackColor = System.Drawing.Color.Gold;
            this.panelbtns.Controls.Add(this.button1);
            this.panelbtns.Controls.Add(this.btconsulta);
            this.panelbtns.Controls.Add(this.btmantenimiento);
            this.panelbtns.Controls.Add(this.pictureBox1);
            this.panelbtns.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelbtns.Location = new System.Drawing.Point(0, 0);
            this.panelbtns.Name = "panelbtns";
            this.panelbtns.Size = new System.Drawing.Size(200, 700);
            this.panelbtns.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btminimizar);
            this.panel1.Controls.Add(this.btcerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 1;
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.Black;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(200, 50);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1000, 650);
            this.contenedor.TabIndex = 2;
            // 
            // btminimizar
            // 
            this.btminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btminimizar.Image = global::ProyectoRestaurante.Properties.Resources.icons8_minimize_window_32;
            this.btminimizar.Location = new System.Drawing.Point(922, 5);
            this.btminimizar.Name = "btminimizar";
            this.btminimizar.Size = new System.Drawing.Size(32, 32);
            this.btminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btminimizar.TabIndex = 1;
            this.btminimizar.TabStop = false;
            this.btminimizar.Click += new System.EventHandler(this.btminimizar_Click);
            this.btminimizar.MouseEnter += new System.EventHandler(this.btminimizar_MouseEnter);
            this.btminimizar.MouseLeave += new System.EventHandler(this.btminimizar_MouseLeave);
            // 
            // btcerrar
            // 
            this.btcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcerrar.Image = global::ProyectoRestaurante.Properties.Resources.icons8_close_window_32;
            this.btcerrar.Location = new System.Drawing.Point(960, 5);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(32, 32);
            this.btcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btcerrar.TabIndex = 0;
            this.btcerrar.TabStop = false;
            this.btcerrar.Click += new System.EventHandler(this.btcerrar_Click);
            this.btcerrar.MouseEnter += new System.EventHandler(this.btcerrar_MouseEnter);
            this.btcerrar.MouseLeave += new System.EventHandler(this.btcerrar_MouseLeave);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ProyectoRestaurante.Properties.Resources.icons8_front_desk_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "      Mostrador           ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btconsulta
            // 
            this.btconsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btconsulta.FlatAppearance.BorderSize = 0;
            this.btconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btconsulta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconsulta.Image = global::ProyectoRestaurante.Properties.Resources.icons8_search_32;
            this.btconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btconsulta.Location = new System.Drawing.Point(-3, 256);
            this.btconsulta.Name = "btconsulta";
            this.btconsulta.Size = new System.Drawing.Size(200, 41);
            this.btconsulta.TabIndex = 3;
            this.btconsulta.Text = "     Consulta             ";
            this.btconsulta.UseVisualStyleBackColor = true;
            this.btconsulta.Click += new System.EventHandler(this.btconsulta_Click);
            // 
            // btmantenimiento
            // 
            this.btmantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmantenimiento.FlatAppearance.BorderSize = 0;
            this.btmantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmantenimiento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmantenimiento.Image = global::ProyectoRestaurante.Properties.Resources.icons8_tools_32;
            this.btmantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmantenimiento.Location = new System.Drawing.Point(0, 176);
            this.btmantenimiento.Name = "btmantenimiento";
            this.btmantenimiento.Size = new System.Drawing.Size(200, 60);
            this.btmantenimiento.TabIndex = 2;
            this.btmantenimiento.Text = "      Mantenimientos";
            this.btmantenimiento.UseVisualStyleBackColor = true;
            this.btmantenimiento.Click += new System.EventHandler(this.btmantenimiento_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoRestaurante.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(0, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuprincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelbtns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menuprincipal_FormClosed);
            this.panelbtns.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbtns;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btminimizar;
        private System.Windows.Forms.PictureBox btcerrar;
        private System.Windows.Forms.Button btmantenimiento;
        private System.Windows.Forms.Button btconsulta;
        private System.Windows.Forms.Button button1;
    }
}