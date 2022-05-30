using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacroExamenGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "Tu nombre es: " + textBoxNombre.Text + " " + textBoxApellido.Text + " Tu edad es de: " + textBoxEdad.Text + " años";
        }
    }
}
