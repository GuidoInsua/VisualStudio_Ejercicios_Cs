namespace Ej_05_I02
{
    partial class Form1_registro
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
            gbx_detallesUsuario = new GroupBox();
            lbl_edad = new Label();
            lbl_direccion = new Label();
            lbl_nombre = new Label();
            nbx_edad = new NumericUpDown();
            tbx_direccion = new TextBox();
            tbx_nombre = new TextBox();
            gbx_genero = new GroupBox();
            rbt_noBinario = new RadioButton();
            rbt_femenino = new RadioButton();
            rbt_masculino = new RadioButton();
            gbx_cursos = new GroupBox();
            cbx_javaScript = new CheckBox();
            cbx_cpp = new CheckBox();
            cbx_cs = new CheckBox();
            lbx_pais = new ListBox();
            bt_ingresar = new Button();
            gbx_detallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbx_edad).BeginInit();
            gbx_genero.SuspendLayout();
            gbx_cursos.SuspendLayout();
            SuspendLayout();
            // 
            // gbx_detallesUsuario
            // 
            gbx_detallesUsuario.Controls.Add(lbl_edad);
            gbx_detallesUsuario.Controls.Add(lbl_direccion);
            gbx_detallesUsuario.Controls.Add(lbl_nombre);
            gbx_detallesUsuario.Controls.Add(nbx_edad);
            gbx_detallesUsuario.Controls.Add(tbx_direccion);
            gbx_detallesUsuario.Controls.Add(tbx_nombre);
            gbx_detallesUsuario.Location = new Point(29, 25);
            gbx_detallesUsuario.Name = "gbx_detallesUsuario";
            gbx_detallesUsuario.Size = new Size(237, 163);
            gbx_detallesUsuario.TabIndex = 0;
            gbx_detallesUsuario.TabStop = false;
            gbx_detallesUsuario.Text = "Detalles del Usuario";
            // 
            // lbl_edad
            // 
            lbl_edad.AutoSize = true;
            lbl_edad.Location = new Point(21, 120);
            lbl_edad.Name = "lbl_edad";
            lbl_edad.Size = new Size(33, 15);
            lbl_edad.TabIndex = 5;
            lbl_edad.Text = "Edad";
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Location = new Point(21, 83);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(57, 15);
            lbl_direccion.TabIndex = 4;
            lbl_direccion.Text = "Direccion";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(21, 41);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 3;
            lbl_nombre.Text = "Nombre";
            // 
            // nbx_edad
            // 
            nbx_edad.Location = new Point(95, 118);
            nbx_edad.Name = "nbx_edad";
            nbx_edad.Size = new Size(120, 23);
            nbx_edad.TabIndex = 2;
            // 
            // tbx_direccion
            // 
            tbx_direccion.Location = new Point(95, 80);
            tbx_direccion.Name = "tbx_direccion";
            tbx_direccion.Size = new Size(120, 23);
            tbx_direccion.TabIndex = 1;
            // 
            // tbx_nombre
            // 
            tbx_nombre.Location = new Point(95, 38);
            tbx_nombre.Name = "tbx_nombre";
            tbx_nombre.Size = new Size(120, 23);
            tbx_nombre.TabIndex = 0;
            // 
            // gbx_genero
            // 
            gbx_genero.Controls.Add(rbt_noBinario);
            gbx_genero.Controls.Add(rbt_femenino);
            gbx_genero.Controls.Add(rbt_masculino);
            gbx_genero.Location = new Point(298, 25);
            gbx_genero.Name = "gbx_genero";
            gbx_genero.Size = new Size(152, 103);
            gbx_genero.TabIndex = 1;
            gbx_genero.TabStop = false;
            gbx_genero.Text = "Genero";
            // 
            // rbt_noBinario
            // 
            rbt_noBinario.AutoSize = true;
            rbt_noBinario.Location = new Point(31, 72);
            rbt_noBinario.Name = "rbt_noBinario";
            rbt_noBinario.Size = new Size(81, 19);
            rbt_noBinario.TabIndex = 2;
            rbt_noBinario.TabStop = true;
            rbt_noBinario.Text = "No binario";
            rbt_noBinario.UseVisualStyleBackColor = true;
            rbt_noBinario.CheckedChanged += rbt_noBinario_CheckedChanged;
            // 
            // rbt_femenino
            // 
            rbt_femenino.AutoSize = true;
            rbt_femenino.Location = new Point(31, 47);
            rbt_femenino.Name = "rbt_femenino";
            rbt_femenino.Size = new Size(78, 19);
            rbt_femenino.TabIndex = 1;
            rbt_femenino.TabStop = true;
            rbt_femenino.Text = "Femenino";
            rbt_femenino.UseVisualStyleBackColor = true;
            rbt_femenino.CheckedChanged += rbt_femenino_CheckedChanged;
            // 
            // rbt_masculino
            // 
            rbt_masculino.AutoSize = true;
            rbt_masculino.Location = new Point(31, 22);
            rbt_masculino.Name = "rbt_masculino";
            rbt_masculino.Size = new Size(80, 19);
            rbt_masculino.TabIndex = 0;
            rbt_masculino.TabStop = true;
            rbt_masculino.Text = "Masculino";
            rbt_masculino.UseVisualStyleBackColor = true;
            rbt_masculino.CheckedChanged += rbt_masculino_CheckedChanged;
            // 
            // gbx_cursos
            // 
            gbx_cursos.Controls.Add(cbx_javaScript);
            gbx_cursos.Controls.Add(cbx_cpp);
            gbx_cursos.Controls.Add(cbx_cs);
            gbx_cursos.Location = new Point(298, 143);
            gbx_cursos.Name = "gbx_cursos";
            gbx_cursos.Size = new Size(152, 106);
            gbx_cursos.TabIndex = 2;
            gbx_cursos.TabStop = false;
            gbx_cursos.Text = "Cursos";
            // 
            // cbx_javaScript
            // 
            cbx_javaScript.AutoSize = true;
            cbx_javaScript.Location = new Point(31, 72);
            cbx_javaScript.Name = "cbx_javaScript";
            cbx_javaScript.Size = new Size(78, 19);
            cbx_javaScript.TabIndex = 2;
            cbx_javaScript.Text = "JavaScript";
            cbx_javaScript.UseVisualStyleBackColor = true;
            cbx_javaScript.CheckedChanged += cbx_javaScript_CheckedChanged;
            // 
            // cbx_cpp
            // 
            cbx_cpp.AutoSize = true;
            cbx_cpp.Location = new Point(31, 47);
            cbx_cpp.Name = "cbx_cpp";
            cbx_cpp.Size = new Size(50, 19);
            cbx_cpp.TabIndex = 1;
            cbx_cpp.Text = "C++";
            cbx_cpp.UseVisualStyleBackColor = true;
            cbx_cpp.CheckedChanged += cbx_cpp_CheckedChanged;
            // 
            // cbx_cs
            // 
            cbx_cs.AutoSize = true;
            cbx_cs.Location = new Point(31, 22);
            cbx_cs.Name = "cbx_cs";
            cbx_cs.Size = new Size(41, 19);
            cbx_cs.TabIndex = 0;
            cbx_cs.Text = "C#";
            cbx_cs.UseVisualStyleBackColor = true;
            cbx_cs.CheckedChanged += cbx_cs_CheckedChanged;
            // 
            // lbx_pais
            // 
            lbx_pais.AccessibleDescription = "";
            lbx_pais.AccessibleName = "";
            lbx_pais.FormattingEnabled = true;
            lbx_pais.ItemHeight = 15;
            lbx_pais.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            lbx_pais.Location = new Point(29, 215);
            lbx_pais.Name = "lbx_pais";
            lbx_pais.Size = new Size(237, 124);
            lbx_pais.TabIndex = 3;
            lbx_pais.Tag = "";
            lbx_pais.SelectedIndexChanged += lbx_pais_SelectedIndexChanged;
            // 
            // bt_ingresar
            // 
            bt_ingresar.Location = new Point(313, 280);
            bt_ingresar.Name = "bt_ingresar";
            bt_ingresar.Size = new Size(122, 34);
            bt_ingresar.TabIndex = 4;
            bt_ingresar.Text = "Ingresar";
            bt_ingresar.UseVisualStyleBackColor = true;
            bt_ingresar.Click += bt_ingresar_Click;
            // 
            // Form1_registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 384);
            Controls.Add(bt_ingresar);
            Controls.Add(lbx_pais);
            Controls.Add(gbx_cursos);
            Controls.Add(gbx_genero);
            Controls.Add(gbx_detallesUsuario);
            Name = "Form1_registro";
            Text = "Registro";
            Load += Form1_Load;
            gbx_detallesUsuario.ResumeLayout(false);
            gbx_detallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbx_edad).EndInit();
            gbx_genero.ResumeLayout(false);
            gbx_genero.PerformLayout();
            gbx_cursos.ResumeLayout(false);
            gbx_cursos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbx_detallesUsuario;
        private Label lbl_edad;
        private Label lbl_direccion;
        private Label lbl_nombre;
        private NumericUpDown nbx_edad;
        private TextBox tbx_direccion;
        private TextBox tbx_nombre;
        private GroupBox gbx_genero;
        private RadioButton rbt_noBinario;
        private RadioButton rbt_femenino;
        private RadioButton rbt_masculino;
        private GroupBox gbx_cursos;
        private CheckBox cbx_javaScript;
        private CheckBox cbx_cpp;
        private CheckBox cbx_cs;
        private ListBox lbx_pais;
        private Button bt_ingresar;
    }
}