using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_05_I01
{
    public partial class Form2 : Form
    {
        string _titulo;
        string _mensaje;

        public Form2()
        {
            InitializeComponent();

        }

        public Form2(string titulo, string mensaje) : this()
        {
            _mensaje = mensaje;
            _titulo = titulo;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_saludo.Text = _titulo;
            lbl_soy.Text = _mensaje;
        }
    }
}
