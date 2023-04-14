namespace Ej_05_I01
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
            tbx_nombre = new TextBox();
            tbx_apellido = new TextBox();
            lbl_nombre = new Label();
            lbl_apellido = new Label();
            btn_saludar = new Button();
            cbx_materias = new ComboBox();
            lbl_materias = new Label();
            SuspendLayout();
            // 
            // tbx_nombre
            // 
            tbx_nombre.Location = new Point(33, 65);
            tbx_nombre.Name = "tbx_nombre";
            tbx_nombre.Size = new Size(158, 23);
            tbx_nombre.TabIndex = 0;
            // 
            // tbx_apellido
            // 
            tbx_apellido.Location = new Point(253, 65);
            tbx_apellido.Name = "tbx_apellido";
            tbx_apellido.Size = new Size(158, 23);
            tbx_apellido.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nombre.Location = new Point(33, 47);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(53, 15);
            lbl_nombre.TabIndex = 2;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_apellido.Location = new Point(253, 47);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(52, 15);
            lbl_apellido.TabIndex = 3;
            lbl_apellido.Text = "Apellido";
            // 
            // btn_saludar
            // 
            btn_saludar.Location = new Point(287, 184);
            btn_saludar.Name = "btn_saludar";
            btn_saludar.Size = new Size(105, 28);
            btn_saludar.TabIndex = 4;
            btn_saludar.Text = "Saludar";
            btn_saludar.UseVisualStyleBackColor = true;
            btn_saludar.Click += btn_saludar_Click;
            // 
            // cbx_materias
            // 
            cbx_materias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_materias.FormattingEnabled = true;
            cbx_materias.Items.AddRange(new object[] { "Programacion I", "ProgramacionII", "LaboratorioI", "Laboratorio II", "Matemetica", "Fisica", "Ingles I", "Ingles II" });
            cbx_materias.Location = new Point(33, 127);
            cbx_materias.Name = "cbx_materias";
            cbx_materias.Size = new Size(378, 23);
            cbx_materias.TabIndex = 5;
            // 
            // lbl_materias
            // 
            lbl_materias.AutoSize = true;
            lbl_materias.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_materias.Location = new Point(33, 109);
            lbl_materias.Name = "lbl_materias";
            lbl_materias.Size = new Size(55, 15);
            lbl_materias.TabIndex = 6;
            lbl_materias.Text = "Materias";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(442, 224);
            Controls.Add(lbl_materias);
            Controls.Add(cbx_materias);
            Controls.Add(btn_saludar);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(tbx_apellido);
            Controls.Add(tbx_nombre);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Hola, Windows Form!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_nombre;
        private TextBox tbx_apellido;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private Button btn_saludar;
        private ComboBox cbx_materias;
        private Label lbl_materias;
    }
}