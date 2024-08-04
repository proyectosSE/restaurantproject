namespace ProyectoRestaurante
{
    partial class mensaje
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
            this.buttCon = new System.Windows.Forms.Button();
            this.buttCan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttCon
            // 
            this.buttCon.Location = new System.Drawing.Point(121, 144);
            this.buttCon.Name = "buttCon";
            this.buttCon.Size = new System.Drawing.Size(91, 46);
            this.buttCon.TabIndex = 0;
            this.buttCon.Text = "Confirmar";
            this.buttCon.UseVisualStyleBackColor = true;
            this.buttCon.Click += new System.EventHandler(this.buttCon_Click);
            // 
            // buttCan
            // 
            this.buttCan.Location = new System.Drawing.Point(267, 144);
            this.buttCan.Name = "buttCan";
            this.buttCan.Size = new System.Drawing.Size(91, 46);
            this.buttCan.TabIndex = 1;
            this.buttCan.Text = "Cancelar";
            this.buttCan.UseVisualStyleBackColor = true;
            this.buttCan.Click += new System.EventHandler(this.buttCan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Esta seguro que desea eliminar?";
            // 
            // mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttCan);
            this.Controls.Add(this.buttCon);
            this.Name = "mensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIRMAR?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttCon;
        private System.Windows.Forms.Button buttCan;
        private System.Windows.Forms.Label label1;
    }
}