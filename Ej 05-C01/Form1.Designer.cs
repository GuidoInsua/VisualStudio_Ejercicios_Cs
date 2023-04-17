namespace Ej_05_C01
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_candado = new Button();
            imgl_candado = new ImageList(components);
            lbl_cotizacion = new Label();
            tbx_cotizacionEuro = new TextBox();
            tbx_cotizacionDolar = new TextBox();
            tbx_cotizacionPeso = new TextBox();
            lbl_cantidadEuro = new Label();
            lbl_cantidadDolar = new Label();
            lbl_cantidadPeso = new Label();
            tbx_cantidadEuro = new TextBox();
            tbx_cantidadDolar = new TextBox();
            tbx_cantidadPeso = new TextBox();
            btn_calcularEuro = new Button();
            btn_calcularDolar = new Button();
            btn_calcularPeso = new Button();
            lbl_resultadoEuro = new Label();
            lbl_resultadoDolar = new Label();
            lbl_resultadoPeso = new Label();
            tbx_euroEnEuro = new TextBox();
            tbx_dolarEnEuro = new TextBox();
            tbx_pesoEnEuro = new TextBox();
            tbx_euroEnDolar = new TextBox();
            tbx_dolarEnDolar = new TextBox();
            tbx_pesoEnDolar = new TextBox();
            tbx_euroEnPeso = new TextBox();
            tbx_dolarEnPeso = new TextBox();
            tbx_pesoEnPeso = new TextBox();
            SuspendLayout();
            // 
            // btn_candado
            // 
            btn_candado.BackColor = SystemColors.ActiveBorder;
            btn_candado.FlatAppearance.BorderColor = Color.Black;
            btn_candado.ImageIndex = 0;
            btn_candado.ImageList = imgl_candado;
            btn_candado.Location = new Point(195, 8);
            btn_candado.Name = "btn_candado";
            btn_candado.Size = new Size(117, 43);
            btn_candado.TabIndex = 0;
            btn_candado.UseVisualStyleBackColor = false;
            btn_candado.Click += btn_candado_Click;
            // 
            // imgl_candado
            // 
            imgl_candado.ColorDepth = ColorDepth.Depth32Bit;
            imgl_candado.ImageStream = (ImageListStreamer)resources.GetObject("imgl_candado.ImageStream");
            imgl_candado.TransparentColor = Color.Transparent;
            imgl_candado.Images.SetKeyName(0, "candado-abierto.png");
            imgl_candado.Images.SetKeyName(1, "candado-cerrado.png");
            // 
            // lbl_cotizacion
            // 
            lbl_cotizacion.AutoSize = true;
            lbl_cotizacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cotizacion.Location = new Point(90, 18);
            lbl_cotizacion.Name = "lbl_cotizacion";
            lbl_cotizacion.Size = new Size(79, 19);
            lbl_cotizacion.TabIndex = 1;
            lbl_cotizacion.Text = "Cotizacion";
            // 
            // tbx_cotizacionEuro
            // 
            tbx_cotizacionEuro.Location = new Point(340, 14);
            tbx_cotizacionEuro.Name = "tbx_cotizacionEuro";
            tbx_cotizacionEuro.Size = new Size(100, 23);
            tbx_cotizacionEuro.TabIndex = 2;
            tbx_cotizacionEuro.Leave += tbx_cotizacionEuro_Leave;
            // 
            // tbx_cotizacionDolar
            // 
            tbx_cotizacionDolar.Location = new Point(446, 14);
            tbx_cotizacionDolar.Name = "tbx_cotizacionDolar";
            tbx_cotizacionDolar.Size = new Size(100, 23);
            tbx_cotizacionDolar.TabIndex = 3;
            tbx_cotizacionDolar.Text = "1";
            tbx_cotizacionDolar.Leave += tbx_cotizacionDolar_Leave;
            // 
            // tbx_cotizacionPeso
            // 
            tbx_cotizacionPeso.Location = new Point(552, 14);
            tbx_cotizacionPeso.Name = "tbx_cotizacionPeso";
            tbx_cotizacionPeso.Size = new Size(100, 23);
            tbx_cotizacionPeso.TabIndex = 4;
            tbx_cotizacionPeso.Leave += tbx_cotizacionPeso_Leave;
            // 
            // lbl_cantidadEuro
            // 
            lbl_cantidadEuro.AutoSize = true;
            lbl_cantidadEuro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cantidadEuro.Location = new Point(12, 82);
            lbl_cantidadEuro.Name = "lbl_cantidadEuro";
            lbl_cantidadEuro.Size = new Size(39, 19);
            lbl_cantidadEuro.TabIndex = 5;
            lbl_cantidadEuro.Text = "Euro";
            // 
            // lbl_cantidadDolar
            // 
            lbl_cantidadDolar.AutoSize = true;
            lbl_cantidadDolar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cantidadDolar.Location = new Point(12, 122);
            lbl_cantidadDolar.Name = "lbl_cantidadDolar";
            lbl_cantidadDolar.Size = new Size(46, 19);
            lbl_cantidadDolar.TabIndex = 6;
            lbl_cantidadDolar.Text = "Dolar";
            // 
            // lbl_cantidadPeso
            // 
            lbl_cantidadPeso.AutoSize = true;
            lbl_cantidadPeso.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cantidadPeso.Location = new Point(12, 160);
            lbl_cantidadPeso.Name = "lbl_cantidadPeso";
            lbl_cantidadPeso.Size = new Size(41, 19);
            lbl_cantidadPeso.TabIndex = 7;
            lbl_cantidadPeso.Text = "Peso";
            // 
            // tbx_cantidadEuro
            // 
            tbx_cantidadEuro.Location = new Point(74, 81);
            tbx_cantidadEuro.Name = "tbx_cantidadEuro";
            tbx_cantidadEuro.Size = new Size(108, 23);
            tbx_cantidadEuro.TabIndex = 8;
            tbx_cantidadEuro.Leave += tbx_candidadEuro_Leave;
            // 
            // tbx_cantidadDolar
            // 
            tbx_cantidadDolar.Location = new Point(74, 121);
            tbx_cantidadDolar.Name = "tbx_cantidadDolar";
            tbx_cantidadDolar.Size = new Size(108, 23);
            tbx_cantidadDolar.TabIndex = 9;
            tbx_cantidadDolar.Leave += tbx_cantidadDolar_Leave;
            // 
            // tbx_cantidadPeso
            // 
            tbx_cantidadPeso.Location = new Point(74, 159);
            tbx_cantidadPeso.Name = "tbx_cantidadPeso";
            tbx_cantidadPeso.Size = new Size(108, 23);
            tbx_cantidadPeso.TabIndex = 10;
            tbx_cantidadPeso.Leave += tbx_cantidadPeso_Leave;
            // 
            // btn_calcularEuro
            // 
            btn_calcularEuro.BackColor = SystemColors.ActiveBorder;
            btn_calcularEuro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_calcularEuro.Location = new Point(217, 81);
            btn_calcularEuro.Name = "btn_calcularEuro";
            btn_calcularEuro.Size = new Size(75, 23);
            btn_calcularEuro.TabIndex = 11;
            btn_calcularEuro.Text = "-->";
            btn_calcularEuro.UseVisualStyleBackColor = false;
            btn_calcularEuro.Click += btn_calcularEuro_Click;
            // 
            // btn_calcularDolar
            // 
            btn_calcularDolar.BackColor = SystemColors.ActiveBorder;
            btn_calcularDolar.Location = new Point(217, 121);
            btn_calcularDolar.Name = "btn_calcularDolar";
            btn_calcularDolar.Size = new Size(75, 23);
            btn_calcularDolar.TabIndex = 12;
            btn_calcularDolar.Text = "-->";
            btn_calcularDolar.UseVisualStyleBackColor = false;
            btn_calcularDolar.Click += btn_calcularDolar_Click;
            // 
            // btn_calcularPeso
            // 
            btn_calcularPeso.BackColor = SystemColors.ActiveBorder;
            btn_calcularPeso.Location = new Point(217, 159);
            btn_calcularPeso.Name = "btn_calcularPeso";
            btn_calcularPeso.Size = new Size(75, 23);
            btn_calcularPeso.TabIndex = 13;
            btn_calcularPeso.Text = "-->";
            btn_calcularPeso.UseVisualStyleBackColor = false;
            btn_calcularPeso.Click += btn_calcularPeso_Click;
            // 
            // lbl_resultadoEuro
            // 
            lbl_resultadoEuro.AutoSize = true;
            lbl_resultadoEuro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_resultadoEuro.Location = new Point(368, 51);
            lbl_resultadoEuro.Name = "lbl_resultadoEuro";
            lbl_resultadoEuro.Size = new Size(39, 19);
            lbl_resultadoEuro.TabIndex = 14;
            lbl_resultadoEuro.Text = "Euro";
            // 
            // lbl_resultadoDolar
            // 
            lbl_resultadoDolar.AutoSize = true;
            lbl_resultadoDolar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_resultadoDolar.Location = new Point(472, 51);
            lbl_resultadoDolar.Name = "lbl_resultadoDolar";
            lbl_resultadoDolar.Size = new Size(46, 19);
            lbl_resultadoDolar.TabIndex = 15;
            lbl_resultadoDolar.Text = "Dolar";
            // 
            // lbl_resultadoPeso
            // 
            lbl_resultadoPeso.AutoSize = true;
            lbl_resultadoPeso.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_resultadoPeso.Location = new Point(583, 51);
            lbl_resultadoPeso.Name = "lbl_resultadoPeso";
            lbl_resultadoPeso.Size = new Size(41, 19);
            lbl_resultadoPeso.TabIndex = 16;
            lbl_resultadoPeso.Text = "Peso";
            // 
            // tbx_euroEnEuro
            // 
            tbx_euroEnEuro.Location = new Point(340, 81);
            tbx_euroEnEuro.Name = "tbx_euroEnEuro";
            tbx_euroEnEuro.ReadOnly = true;
            tbx_euroEnEuro.Size = new Size(100, 23);
            tbx_euroEnEuro.TabIndex = 17;
            // 
            // tbx_dolarEnEuro
            // 
            tbx_dolarEnEuro.Location = new Point(340, 121);
            tbx_dolarEnEuro.Name = "tbx_dolarEnEuro";
            tbx_dolarEnEuro.ReadOnly = true;
            tbx_dolarEnEuro.Size = new Size(100, 23);
            tbx_dolarEnEuro.TabIndex = 18;
            // 
            // tbx_pesoEnEuro
            // 
            tbx_pesoEnEuro.Location = new Point(340, 159);
            tbx_pesoEnEuro.Name = "tbx_pesoEnEuro";
            tbx_pesoEnEuro.ReadOnly = true;
            tbx_pesoEnEuro.Size = new Size(100, 23);
            tbx_pesoEnEuro.TabIndex = 19;
            // 
            // tbx_euroEnDolar
            // 
            tbx_euroEnDolar.Location = new Point(446, 81);
            tbx_euroEnDolar.Name = "tbx_euroEnDolar";
            tbx_euroEnDolar.ReadOnly = true;
            tbx_euroEnDolar.Size = new Size(100, 23);
            tbx_euroEnDolar.TabIndex = 20;
            // 
            // tbx_dolarEnDolar
            // 
            tbx_dolarEnDolar.Location = new Point(446, 121);
            tbx_dolarEnDolar.Name = "tbx_dolarEnDolar";
            tbx_dolarEnDolar.ReadOnly = true;
            tbx_dolarEnDolar.Size = new Size(100, 23);
            tbx_dolarEnDolar.TabIndex = 21;
            // 
            // tbx_pesoEnDolar
            // 
            tbx_pesoEnDolar.Location = new Point(446, 159);
            tbx_pesoEnDolar.Name = "tbx_pesoEnDolar";
            tbx_pesoEnDolar.ReadOnly = true;
            tbx_pesoEnDolar.Size = new Size(100, 23);
            tbx_pesoEnDolar.TabIndex = 22;
            // 
            // tbx_euroEnPeso
            // 
            tbx_euroEnPeso.Location = new Point(552, 81);
            tbx_euroEnPeso.Name = "tbx_euroEnPeso";
            tbx_euroEnPeso.ReadOnly = true;
            tbx_euroEnPeso.Size = new Size(100, 23);
            tbx_euroEnPeso.TabIndex = 23;
            // 
            // tbx_dolarEnPeso
            // 
            tbx_dolarEnPeso.Location = new Point(552, 121);
            tbx_dolarEnPeso.Name = "tbx_dolarEnPeso";
            tbx_dolarEnPeso.ReadOnly = true;
            tbx_dolarEnPeso.Size = new Size(100, 23);
            tbx_dolarEnPeso.TabIndex = 24;
            // 
            // tbx_pesoEnPeso
            // 
            tbx_pesoEnPeso.Location = new Point(552, 159);
            tbx_pesoEnPeso.Name = "tbx_pesoEnPeso";
            tbx_pesoEnPeso.ReadOnly = true;
            tbx_pesoEnPeso.Size = new Size(100, 23);
            tbx_pesoEnPeso.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(666, 206);
            Controls.Add(tbx_pesoEnPeso);
            Controls.Add(tbx_dolarEnPeso);
            Controls.Add(tbx_euroEnPeso);
            Controls.Add(tbx_pesoEnDolar);
            Controls.Add(tbx_dolarEnDolar);
            Controls.Add(tbx_euroEnDolar);
            Controls.Add(tbx_pesoEnEuro);
            Controls.Add(tbx_dolarEnEuro);
            Controls.Add(tbx_euroEnEuro);
            Controls.Add(lbl_resultadoPeso);
            Controls.Add(lbl_resultadoDolar);
            Controls.Add(lbl_resultadoEuro);
            Controls.Add(btn_calcularPeso);
            Controls.Add(btn_calcularDolar);
            Controls.Add(btn_calcularEuro);
            Controls.Add(tbx_cantidadPeso);
            Controls.Add(tbx_cantidadDolar);
            Controls.Add(tbx_cantidadEuro);
            Controls.Add(lbl_cantidadPeso);
            Controls.Add(lbl_cantidadDolar);
            Controls.Add(lbl_cantidadEuro);
            Controls.Add(tbx_cotizacionPeso);
            Controls.Add(tbx_cotizacionDolar);
            Controls.Add(tbx_cotizacionEuro);
            Controls.Add(lbl_cotizacion);
            Controls.Add(btn_candado);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_candado;
        private Label lbl_cotizacion;
        private TextBox tbx_cotizacionEuro;
        private TextBox tbx_cotizacionDolar;
        private TextBox tbx_cotizacionPeso;
        private Label lbl_cantidadEuro;
        private Label lbl_cantidadDolar;
        private Label lbl_cantidadPeso;
        private TextBox tbx_cantidadEuro;
        private TextBox tbx_cantidadDolar;
        private TextBox tbx_cantidadPeso;
        private Button btn_calcularEuro;
        private Button btn_calcularDolar;
        private Button btn_calcularPeso;
        private Label lbl_resultadoEuro;
        private Label lbl_resultadoDolar;
        private Label lbl_resultadoPeso;
        private TextBox tbx_euroEnEuro;
        private TextBox tbx_dolarEnEuro;
        private TextBox tbx_pesoEnEuro;
        private TextBox tbx_euroEnDolar;
        private TextBox tbx_dolarEnDolar;
        private TextBox tbx_pesoEnDolar;
        private TextBox tbx_euroEnPeso;
        private TextBox tbx_dolarEnPeso;
        private TextBox tbx_pesoEnPeso;
        private ImageList imgl_candado;
    }
}