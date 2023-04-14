namespace Ej_05_I02
{
    public partial class Form1_registro : Form
    {
        private string _genero;
        private string[] _cursos = new string[3];

        public Form1_registro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_ingresar_Click(object sender, EventArgs e)
        {

            Ingresante unIngresante = new Ingresante(_cursos, tbx_direccion.Text, (int)nbx_edad.Value, _genero, tbx_nombre.Text, lbx_pais.Text);

            MessageBox.Show($"{unIngresante.Mostrar()}");
        }

        private void rbt_masculino_CheckedChanged(object sender, EventArgs e)
        {
            _genero = "Masculino";
        }

        private void rbt_femenino_CheckedChanged(object sender, EventArgs e)
        {
            _genero = "Femenino";
        }

        private void rbt_noBinario_CheckedChanged(object sender, EventArgs e)
        {
            _genero = "No binario";
        }

        private void cbx_cs_CheckedChanged(object sender, EventArgs e)
        {
            string box = "C#";

            if (cbx_cs.Checked == true)
            {
                for (int i = 0; i < _cursos.Length; i++)
                {
                    if (_cursos[i] == null)
                    {
                        _cursos[i] = box;
                        break;
                    }
                }
            }

            if (cbx_cs.Checked == false)
            {
                for (int i = 0; i < _cursos.Length; i++)
                {
                    if (_cursos[i] == box)
                    {
                        _cursos[i] = null;
                        break;
                    }
                }
            }
        }

        private void cbx_javaScript_CheckedChanged(object sender, EventArgs e)
        {
            string box = "JavaScript";

            if (cbx_javaScript.Checked == true)
            {
                for (int i = 0; i < _cursos.Length; i++)
                {
                    if (_cursos[i] == null)
                    {
                        _cursos[i] = box;
                        break;
                    }
                }
            }

            if (cbx_javaScript.Checked == false)
            {
                for (int i = 0; i < _cursos.Length; i++)
                {
                    if (_cursos[i] == box)
                    {
                        _cursos[i] = null;
                        break;
                    }
                }
            }
        }

        private void cbx_cpp_CheckedChanged(object sender, EventArgs e)
        {
            string box = "C++";

            if (cbx_cpp.Checked == true)
            {
                for (int i = 0; i < _cursos.Length; i++)
                {
                    if (_cursos[i] == null)
                    {
                        _cursos[i] = box;
                        break;
                    }
                }
            }

            if (cbx_cpp.Checked == false)
            {
                for (int i = 0; i < _cursos.Length; i++)
                {
                    if (_cursos[i] == box)
                    {
                        _cursos[i] = null;
                        break;
                    }
                }
            }
        }

        private void lbx_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}