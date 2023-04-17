namespace Ej_06_I03
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
            rtbx_palabras = new RichTextBox();
            btn_calcular = new Button();
            SuspendLayout();
            // 
            // rtbx_palabras
            // 
            rtbx_palabras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbx_palabras.Location = new Point(12, 12);
            rtbx_palabras.Name = "rtbx_palabras";
            rtbx_palabras.Size = new Size(776, 374);
            rtbx_palabras.TabIndex = 0;
            rtbx_palabras.Text = "";
            // 
            // btn_calcular
            // 
            btn_calcular.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_calcular.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_calcular.Location = new Point(663, 392);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(125, 46);
            btn_calcular.TabIndex = 1;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_calcular);
            Controls.Add(rtbx_palabras);
            Name = "Form1";
            Text = "Contador de palabras";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbx_palabras;
        private Button btn_calcular;
    }
}