using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_WindowsForm
{
    public partial class Form2 : Form
    {
        Form1 primerForm;
        public Form2(Form1 formulario1)
        {
            primerForm = formulario1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblNumero.Text = primerForm.txtNum1.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            primerForm.Show();
        }
    }

    public partial class Estudiante
    {
        public Estudiante()
        {
            Nombre = "NA";
            Edad = 0;
            Egresado = false;
        }
        public Estudiante(string nom, int edad, bool egre)
        {
            Nombre = nom;
            Edad = edad;
            Egresado = egre;
        }
    }
}
