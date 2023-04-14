using System.Text;

namespace Ej_05_I01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_saludar_Click(object sender, EventArgs e)
        {   
            string titulo = "¡Hola, Windows Forms!";
            string mensaje = $"Soy {tbx_nombre.Text} {tbx_apellido.Text} y mi materia favorita es {cbx_materias.SelectedItem}.";

            if (Validar())
            {
                Form2 f2 = new Form2(titulo, mensaje);
                f2.ShowDialog();
            }
        }

        private bool Validar()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(tbx_nombre.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(tbx_apellido.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Apellido");
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_materias.Text = "Programacion I";
        }
    }
}