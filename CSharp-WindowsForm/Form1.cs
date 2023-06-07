namespace CSharp_WindowsForm
{
    public partial class Form1 : Form
    {
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
    }
}