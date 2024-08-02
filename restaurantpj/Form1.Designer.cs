namespace restaurantpj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            trackBar1 = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(247, 167);
            button1.Name = "button1";
            button1.Size = new Size(273, 127);
            button1.TabIndex = 0;
            button1.Text = "prueba";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 99);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 1;
            label1.Text = "waos";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(247, 352);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(273, 69);
            trackBar1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(467, 99);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 3;
            label2.Text = "waos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 99);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 4;
            label3.Text = "waos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(trackBar1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TrackBar trackBar1;
        private Label label2;
        private Label label3;
    }
}
