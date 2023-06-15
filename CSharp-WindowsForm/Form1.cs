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

        Graphics graphics;
        Pen boligrafo;
        Point p_ini = new Point(5, 5), p_end = new Point(20, 50);
        Rectangle rect = new Rectangle(5, 5, 50, 50);
        private void paint_de_lienzo(object sender, PaintEventArgs e)
        {

            graphics = lienzo.CreateGraphics();//inicializar el objeto Graphics
            boligrafo = new Pen(Color.Red, 10.0f);
            graphics.DrawLine(boligrafo, p_ini, p_end);
            boligrafo.Color = Color.Pink;
            graphics.DrawRectangle(boligrafo, rect);
            //graphics.DrawP
            textBox6.Text = "REDIBUJADO";
        }

        private void hacia_arriba(object sender, EventArgs e)
        {
            p_ini.Y -= 5;
            p_end.Y -= 5;
            lienzo.Invalidate();
        }

        private void hacia_abajo(object sender, EventArgs e)
        {
            p_ini.Y += 5;
            p_end.Y += 5;
            lienzo.Invalidate();
        }

        private void hacia_izq(object sender, EventArgs e)
        {
            p_ini.X -= 5;
            p_end.X -= 5;
            lienzo.Invalidate();
        }

        private void hacia_der(object sender, EventArgs e)
        {
            p_ini.X += 5;
            p_end.X += 5;
            lienzo.Invalidate();
        }



        private void tecla_presionada(object sender, KeyEventArgs e)
        {
            //saber qué tecla se presionó
            Console.WriteLine("Presionado");
            textBox6.Text = e.KeyValue + "";
            switch (e.KeyData)
            {
                case Keys.A:
                    p_ini.X -= 5;
                    p_end.X -= 5;
                    lienzo.Invalidate();
                    break;
                case Keys.D:
                    p_ini.X += 5;
                    p_end.X += 5;
                    lienzo.Invalidate();
                    break;
                case Keys.W:
                    p_ini.Y -= 5;
                    p_end.Y -= 5;
                    lienzo.Invalidate();
                    break;
                case Keys.S:
                    p_ini.Y += 5;
                    p_end.Y += 5;
                    lienzo.Invalidate();
                    break;
                default:
                    lienzo.Invalidate();
                    break;
            }
        }

        private void evento_raton_down(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    rect.X = e.X;
                    rect.Y = e.Y;
                    lienzo.Invalidate();
                    break;
                case MouseButtons.Right:
                    break;
                default:
                    break;
            }
        }

        private void raton_mover(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    rect.X = e.X;
                    rect.Y = e.Y;
                    lienzo.Invalidate();
                    break;
                case MouseButtons.Right:
                    break;
                default:
                    break;
            }
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