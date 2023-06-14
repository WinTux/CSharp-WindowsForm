namespace CSharp_WindowsForm
{
    public partial class Form1 : Form
    {
        List<string> listaNombres = new List<string>();


        Stack<string> pilaDepartamentos = new Stack<string>();
        Queue<string> colaClientes = new Queue<string>();
        Usuario usu;
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
        private void mostrar()
        {
            txtLista1.Text = "";
            txtValorLista.Text = "";
            foreach (string nombre in listaNombres)
            {
                txtLista1.Text += nombre + "\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Pila (Stack)
            pilaDepartamentos.Push(txtDepto.Text);
            //var elem = pilaDepartamentos.Peek();//Rescata el elemento en la cima sin quitarlo.
            mostrarPila();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var elemento = pilaDepartamentos.Pop();
            mostrarPila();
            txtSacado.Text = elemento;
        }

        private void mostrarPila()
        {
            txtContenidoPila.Text = "";
            foreach (string depto in pilaDepartamentos)
                txtContenidoPila.Text += depto + "\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Cola (Queue)
            colaClientes.Enqueue(txtCliente.Text);
            mostrarQueue();
        }

        private void mostrarQueue()
        {
            txtCola.Text = "";
            foreach (string depto in colaClientes)
                txtCola.Text += depto + "\n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (colaClientes.Count > 0)
                txtSacadoCola.Text = colaClientes.Dequeue();
            else
                txtSacadoCola.Text = "Cola vacía";
            mostrarQueue();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            usu = new Usuario(
                textBox1.Text,
                textBox2.Text,
                int.Parse(textBox3.Text),
                textBox4.Text,
                textBox5.Text);
            richTextBox1.Text = usu + "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int original = int.Parse(txtPrimitivaOriginal.Text);
            int copia = original;
            copia = 777;
            txtPrimitivaOriginalMostrar.Text = original + "";
            txtPrimitivaCopiaMostrar.Text = copia + "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Copiar de Objeto (por referencia)
            Usuario usuCopia = usu;
            usuCopia.nombre = "PEPE";
            usuCopia.email = "pp@pepelandia.es";
            txtObjetoOriginalMostrar.Text = usu.ToString();
            txtObjetoCopiaMostrar.Text = usuCopia.ToString();

            //Copiar de Objeto (por valor)
            Usuario usuCopia2 = new Usuario(usu.nombre, usu.pass, usu.edad, usu.direccion, usu.email);


            usuCopia2.nombre = "ANITA";
            usuCopia2.email = "ani@gmail.com";
            txtObjetoOriginalMostrar.Text = usu.ToString();
            txtObjetoCopiaMostrar.Text = usuCopia2.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 segundaVentana = new Form2(this);

            segundaVentana.Show();
            this.Hide();
            //segundaVentana.Visible = true;
        }

        private void Clickeado(object o, EventArgs e)
        {
            textBox6.Text = "Se hizo clic en el botón Ejemplo 1";
        }

        private void Presionando_boton_ejemplo_2(object sender, EventArgs e)
        {
            textBox6.Text = "Ejemplo 2";
        }

        private void Movimiento_mouse_en_ejemplo_1(object sender, MouseEventArgs e)
        {
            textBox6.Text = textBox6.Text + "MOUSE!!!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void paint_de_lienzo(object sender, PaintEventArgs e)
        {
            
            Pen boli = new Pen(Color.Red);
            boli.Width = 3;
            e.Graphics.DrawLine(boli,new Point(10,10),new Point(70,30));
            boli.Color = Color.Green;
            e.Graphics.DrawRectangle(boli, 10, 10, 30, 20);
            Rectangle rect = new Rectangle();
            //modificar dinámicamente las figuras (eventos)
        }
    }

    public class Usuario
    {
        public string nombre { get; set; }
        public string pass { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public Usuario(string nombre, string pass, int edad, string dir, string email)
        {
            this.nombre = nombre;
            this.pass = pass;
            this.edad = edad;
            direccion = dir;
            this.email = email;
        }
        public override string ToString()
        {
            return "{ 'nombre': " + nombre + ", 'email: '" + email + " }";
        }
    }
    public partial class Estudiante
    {
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, Es egresado: {Egresado}";
        }
        public string Estudiar()
        {
            return $"Soy {Nombre} y estoy estudiando.";
        }
    }
}
namespace diferente
{

}