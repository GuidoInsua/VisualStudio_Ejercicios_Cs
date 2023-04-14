namespace Ej_05_I01
{
    partial class Form2
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
            lbl_saludo = new Label();
            lbl_soy = new Label();
            SuspendLayout();
            // 
            // lbl_saludo
            // 
            lbl_saludo.AutoSize = true;
            lbl_saludo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_saludo.Location = new Point(50, 34);
            lbl_saludo.Name = "lbl_saludo";
            lbl_saludo.Size = new Size(213, 25);
            lbl_saludo.TabIndex = 0;
            lbl_saludo.Text = "Hola, Windows Forms!";
            // 
            // lbl_soy
            // 
            lbl_soy.AutoSize = true;
            lbl_soy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_soy.Location = new Point(50, 104);
            lbl_soy.Name = "lbl_soy";
            lbl_soy.Size = new Size(40, 21);
            lbl_soy.TabIndex = 1;
            lbl_soy.Text = "Soy ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(611, 170);
            Controls.Add(lbl_soy);
            Controls.Add(lbl_saludo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Saludo";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_saludo;
        private Label lbl_soy;
    }
}