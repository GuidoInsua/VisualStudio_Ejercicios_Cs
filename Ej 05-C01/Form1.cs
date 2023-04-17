namespace Ej_05_C01
{
    public partial class Form1 : Form
    {
        private Peso misPesos;
        private Dolar misDolares;
        private Euro misEuros;

        private bool estadoCandado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            misPesos = new Peso(0);
            misDolares = new Dolar(0);
            misEuros = new Euro(0);

            estadoCandado = false;
        }

        private void tbx_cotizacionEuro_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(tbx_cotizacionEuro.Text, out _))
            {
                Euro.CotzRespectoDolar = Convert.ToDouble(tbx_cotizacionEuro.Text);
            }
            else { tbx_cotizacionEuro.Text = ""; }
        }

        private void tbx_cotizacionPeso_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(tbx_cotizacionPeso.Text, out _))
            {
                Peso.CotzRespectoDolar = Convert.ToDouble(tbx_cotizacionPeso.Text);
            }
            else { tbx_cotizacionPeso.Text = ""; }
        }

        private void tbx_cotizacionDolar_Leave(object sender, EventArgs e)
        {
            tbx_cotizacionDolar.Text = "1";
        }

        private void tbx_candidadEuro_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(tbx_cantidadEuro.Text, out _))
            {
                misEuros.Cantidad = Convert.ToDouble(tbx_cantidadEuro.Text);
            }
            else { tbx_cantidadEuro.Text = ""; }
        }

        private void tbx_cantidadDolar_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(tbx_cantidadDolar.Text, out _))
            {
                misDolares.Cantidad = Convert.ToDouble(tbx_cantidadDolar.Text);
            }
            else { tbx_cantidadDolar.Text = ""; }
        }

        private void tbx_cantidadPeso_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(tbx_cantidadPeso.Text, out _))
            {
                misPesos.Cantidad = Convert.ToDouble(tbx_cantidadPeso.Text);
            }
            else { tbx_cantidadPeso.Text = ""; }
        }

        private void btn_calcularEuro_Click(object sender, EventArgs e)
        {
            if (tbx_cantidadEuro != null)
            {
                tbx_euroEnEuro.Text = $"{misEuros.Cantidad:F3}";
                tbx_euroEnDolar.Text = $"{((Dolar)misEuros).Cantidad:F3}";
                tbx_euroEnPeso.Text = $"{((Peso)misEuros).Cantidad:F3}";
            }
        }

        private void btn_calcularDolar_Click(object sender, EventArgs e)
        {
            if (tbx_cantidadDolar != null)
            {
                tbx_dolarEnEuro.Text = $"{((Euro)misDolares).Cantidad:F3}";
                tbx_dolarEnDolar.Text = $"{misDolares.Cantidad:F3}";
                tbx_dolarEnPeso.Text = $"{((Peso)misDolares).Cantidad:F3}";
            }
        }

        private void btn_calcularPeso_Click(object sender, EventArgs e)
        {
            if (tbx_cantidadPeso != null)
            {
                tbx_pesoEnEuro.Text = $"{((Euro)misPesos).Cantidad:F3}";
                tbx_pesoEnDolar.Text = $"{((Dolar)misPesos).Cantidad:F3}";
                tbx_pesoEnPeso.Text = $"{misPesos.Cantidad:F3}";
            }
        }

        private void btn_candado_Click(object sender, EventArgs e)
        {
            estadoCandado = !estadoCandado;

            tbx_cotizacionEuro.ReadOnly = estadoCandado;
            tbx_cotizacionDolar.ReadOnly = estadoCandado;
            tbx_cotizacionPeso.ReadOnly = estadoCandado;

            if(estadoCandado)
            {
                btn_candado.ImageIndex = 1;
            }
            else
            {
                btn_candado.ImageIndex = 0;
            }
        }
    }
}