namespace CSharp_WindowsForm
{
    public partial class Form1 : Form
    {
        List<string> listaNombres = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n1 = txtNum1.Text;
            string n2 = txtNum2.Text;
            //parse
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;

            bool correcto = int.TryParse(n1, out num1);
            bool correcto2 = int.TryParse(n2, out num2);
            if (correcto && correcto2)
            {
                //operación
                resultado = num1 + num2;
                //mostrar el resultado
                lblRes.Text = "Resultado: " + resultado.ToString();
                //lblRes.Text = resultado + "";
            }
            else
            {
                //mostrar mensaje de error
                lblRes.Text = "Por favor ingrese números enteros pos ó neg ";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaNombres.Add(txtValorLista.Text);
            mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listaNombres.Remove(txtValorLista.Text);
            mostrar();
        }
        private void mostrar() {
            txtLista1.Text = "";
            txtValorLista.Text = "";
            foreach (string nombre in listaNombres)
            {
                txtLista1.Text += nombre + "\n";
            }
        }
    }
}