namespace CSharp_WindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            lblRes = new Label();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            panel3 = new Panel();
            txtCola = new RichTextBox();
            txtSacadoCola = new TextBox();
            label6 = new Label();
            button7 = new Button();
            button6 = new Button();
            txtCliente = new TextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            panel2 = new Panel();
            txtContenidoPila = new RichTextBox();
            label4 = new Label();
            txtSacado = new TextBox();
            button5 = new Button();
            button4 = new Button();
            txtDepto = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            panel1 = new Panel();
            txtLista1 = new RichTextBox();
            button2 = new Button();
            txtValorLista = new TextBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            groupBox6 = new GroupBox();
            panel5 = new Panel();
            txtObjetoCopiaMostrar = new TextBox();
            label14 = new Label();
            txtObjetoOriginalMostrar = new TextBox();
            label15 = new Label();
            button10 = new Button();
            panel4 = new Panel();
            txtPrimitivaCopiaMostrar = new TextBox();
            label13 = new Label();
            txtPrimitivaOriginalMostrar = new TextBox();
            label12 = new Label();
            txtPrimitivaOriginal = new TextBox();
            button9 = new Button();
            groupBox5 = new GroupBox();
            richTextBox1 = new RichTextBox();
            button8 = new Button();
            textBox5 = new TextBox();
            label11 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            tabPage4 = new TabPage();
            button18 = new Button();
            groupBox7 = new GroupBox();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            lienzo = new Panel();
            button13 = new Button();
            button12 = new Button();
            textBox6 = new TextBox();
            button11 = new Button();
            button19 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            groupBox5.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(684, 407);
            tabControl1.TabIndex = 0;
            tabControl1.KeyDown += tecla_presionada;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(676, 379);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ejemplo TextBox";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblRes);
            groupBox1.Controls.Add(txtNum2);
            groupBox1.Controls.Add(txtNum1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 136);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sumador";
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(18, 98);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(106, 20);
            lblRes.TabIndex = 4;
            lblRes.Text = "Resultado:";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(159, 59);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 27);
            txtNum2.TabIndex = 3;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(15, 59);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 27);
            txtNum1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(312, 59);
            button1.Name = "button1";
            button1.Size = new Size(105, 30);
            button1.TabIndex = 1;
            button1.Text = "SUMAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(301, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese dos numeros para sumar:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(676, 379);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Estructuras de datos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel3);
            groupBox4.Controls.Add(txtSacadoCola);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(button7);
            groupBox4.Controls.Add(button6);
            groupBox4.Controls.Add(txtCliente);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(449, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(218, 314);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Colas";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtCola);
            panel3.Location = new Point(0, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(212, 195);
            panel3.TabIndex = 6;
            // 
            // txtCola
            // 
            txtCola.Location = new Point(11, 9);
            txtCola.Name = "txtCola";
            txtCola.Size = new Size(198, 182);
            txtCola.TabIndex = 0;
            txtCola.Text = "";
            // 
            // txtSacadoCola
            // 
            txtSacadoCola.Location = new Point(112, 280);
            txtSacadoCola.Name = "txtSacadoCola";
            txtSacadoCola.Size = new Size(100, 23);
            txtSacadoCola.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 285);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 4;
            label6.Text = "Sacado:";
            // 
            // button7
            // 
            button7.Location = new Point(137, 51);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 3;
            button7.Text = "Quitar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(6, 51);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 2;
            button6.Text = "Agregar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(112, 22);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 0;
            label5.Text = "Cliente:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtSacado);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(txtDepto);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(217, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(209, 317);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pilas";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtContenidoPila);
            panel2.Location = new Point(9, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 191);
            panel2.TabIndex = 6;
            // 
            // txtContenidoPila
            // 
            txtContenidoPila.Location = new Point(8, 14);
            txtContenidoPila.Name = "txtContenidoPila";
            txtContenidoPila.Size = new Size(172, 174);
            txtContenidoPila.TabIndex = 0;
            txtContenidoPila.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 288);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 5;
            label4.Text = "Sacado:";
            // 
            // txtSacado
            // 
            txtSacado.Location = new Point(92, 280);
            txtSacado.Name = "txtSacado";
            txtSacado.Size = new Size(100, 23);
            txtSacado.TabIndex = 4;
            // 
            // button5
            // 
            button5.Location = new Point(117, 51);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 3;
            button5.Text = "Quitar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(9, 51);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 2;
            button4.Text = "Agregar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtDepto
            // 
            txtDepto.Location = new Point(92, 22);
            txtDepto.Name = "txtDepto";
            txtDepto.Size = new Size(100, 23);
            txtDepto.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 25);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 0;
            label3.Text = "Departamento:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(txtValorLista);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(199, 317);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listas";
            // 
            // button3
            // 
            button3.Location = new Point(106, 51);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Quitar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtLista1);
            panel1.Location = new Point(16, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 223);
            panel1.TabIndex = 4;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(3, 3);
            txtLista1.Name = "txtLista1";
            txtLista1.Size = new Size(159, 217);
            txtLista1.TabIndex = 1;
            txtLista1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(16, 51);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtValorLista
            // 
            txtValorLista.Location = new Point(70, 22);
            txtValorLista.Name = "txtValorLista";
            txtValorLista.Size = new Size(111, 23);
            txtValorLista.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 25);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox6);
            tabPage3.Controls.Add(groupBox5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(676, 379);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Valor-Referencia";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(panel5);
            groupBox6.Controls.Add(panel4);
            groupBox6.Location = new Point(197, 11);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(465, 307);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "groupBox6";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtObjetoCopiaMostrar);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(txtObjetoOriginalMostrar);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(button10);
            panel5.Location = new Point(32, 182);
            panel5.Name = "panel5";
            panel5.Size = new Size(402, 114);
            panel5.TabIndex = 1;
            // 
            // txtObjetoCopiaMostrar
            // 
            txtObjetoCopiaMostrar.Location = new Point(185, 59);
            txtObjetoCopiaMostrar.Name = "txtObjetoCopiaMostrar";
            txtObjetoCopiaMostrar.Size = new Size(207, 23);
            txtObjetoCopiaMostrar.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(85, 62);
            label14.Name = "label14";
            label14.Size = new Size(96, 15);
            label14.TabIndex = 8;
            label14.Text = "Variable copiada:";
            // 
            // txtObjetoOriginalMostrar
            // 
            txtObjetoOriginalMostrar.Location = new Point(185, 12);
            txtObjetoOriginalMostrar.Name = "txtObjetoOriginalMostrar";
            txtObjetoOriginalMostrar.Size = new Size(207, 23);
            txtObjetoOriginalMostrar.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(85, 15);
            label15.Name = "label15";
            label15.Size = new Size(94, 15);
            label15.TabIndex = 6;
            label15.Text = "Variable original:";
            // 
            // button10
            // 
            button10.Location = new Point(3, 58);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 0;
            button10.Text = "Copiar";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtPrimitivaCopiaMostrar);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(txtPrimitivaOriginalMostrar);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(txtPrimitivaOriginal);
            panel4.Controls.Add(button9);
            panel4.Location = new Point(29, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(403, 122);
            panel4.TabIndex = 0;
            // 
            // txtPrimitivaCopiaMostrar
            // 
            txtPrimitivaCopiaMostrar.Location = new Point(273, 61);
            txtPrimitivaCopiaMostrar.Name = "txtPrimitivaCopiaMostrar";
            txtPrimitivaCopiaMostrar.Size = new Size(100, 23);
            txtPrimitivaCopiaMostrar.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(161, 64);
            label13.Name = "label13";
            label13.Size = new Size(96, 15);
            label13.TabIndex = 4;
            label13.Text = "Variable copiada:";
            // 
            // txtPrimitivaOriginalMostrar
            // 
            txtPrimitivaOriginalMostrar.Location = new Point(273, 14);
            txtPrimitivaOriginalMostrar.Name = "txtPrimitivaOriginalMostrar";
            txtPrimitivaOriginalMostrar.Size = new Size(100, 23);
            txtPrimitivaOriginalMostrar.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(159, 17);
            label12.Name = "label12";
            label12.Size = new Size(94, 15);
            label12.TabIndex = 2;
            label12.Text = "Variable original:";
            // 
            // txtPrimitivaOriginal
            // 
            txtPrimitivaOriginal.Location = new Point(15, 14);
            txtPrimitivaOriginal.Name = "txtPrimitivaOriginal";
            txtPrimitivaOriginal.Size = new Size(100, 23);
            txtPrimitivaOriginal.TabIndex = 1;
            // 
            // button9
            // 
            button9.Location = new Point(15, 60);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 0;
            button9.Text = "Copiar";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(richTextBox1);
            groupBox5.Controls.Add(button8);
            groupBox5.Controls.Add(textBox5);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(textBox4);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(textBox3);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(textBox2);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(textBox1);
            groupBox5.Controls.Add(label7);
            groupBox5.Location = new Point(3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(185, 322);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Usuario:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 184);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(173, 132);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button8
            // 
            button8.Location = new Point(85, 155);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 2;
            button8.Text = "Crear";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(60, 126);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(4, 129);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 0;
            label11.Text = "email:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(60, 97);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 100);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 0;
            label10.Text = "Dirección:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(60, 68);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 71);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 0;
            label9.Text = "Edad:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 42);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 0;
            label8.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 13);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 0;
            label7.Text = "Usuario:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button19);
            tabPage4.Controls.Add(button18);
            tabPage4.Controls.Add(groupBox7);
            tabPage4.Controls.Add(button13);
            tabPage4.Controls.Add(button12);
            tabPage4.Controls.Add(textBox6);
            tabPage4.Controls.Add(button11);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(676, 379);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Otra ventana";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(432, 325);
            button18.Name = "button18";
            button18.Size = new Size(75, 23);
            button18.TabIndex = 5;
            button18.Text = "Deshacer";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(button17);
            groupBox7.Controls.Add(button16);
            groupBox7.Controls.Add(button15);
            groupBox7.Controls.Add(button14);
            groupBox7.Controls.Add(lienzo);
            groupBox7.Location = new Point(242, 17);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(414, 293);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            groupBox7.Text = "Graphics";
            // 
            // button17
            // 
            button17.Location = new Point(352, 118);
            button17.Name = "button17";
            button17.Size = new Size(56, 23);
            button17.TabIndex = 4;
            button17.Text = "v";
            button17.UseVisualStyleBackColor = true;
            button17.Click += hacia_abajo;
            // 
            // button16
            // 
            button16.Location = new Point(379, 98);
            button16.Name = "button16";
            button16.Size = new Size(29, 23);
            button16.TabIndex = 3;
            button16.Text = ">";
            button16.UseVisualStyleBackColor = true;
            button16.Click += hacia_der;
            // 
            // button15
            // 
            button15.Location = new Point(352, 98);
            button15.Name = "button15";
            button15.Size = new Size(30, 23);
            button15.TabIndex = 2;
            button15.Text = "<";
            button15.UseVisualStyleBackColor = true;
            button15.Click += hacia_izq;
            // 
            // button14
            // 
            button14.Location = new Point(352, 78);
            button14.Name = "button14";
            button14.Size = new Size(56, 23);
            button14.TabIndex = 1;
            button14.Text = "^";
            button14.UseVisualStyleBackColor = true;
            button14.Click += hacia_arriba;
            // 
            // lienzo
            // 
            lienzo.Location = new Point(27, 39);
            lienzo.Name = "lienzo";
            lienzo.Size = new Size(316, 221);
            lienzo.TabIndex = 0;
            lienzo.Paint += paint_de_lienzo;
            lienzo.MouseDown += evento_raton_down;
            lienzo.MouseMove += raton_mover;
            // 
            // button13
            // 
            button13.Location = new Point(121, 213);
            button13.Name = "button13";
            button13.Size = new Size(75, 23);
            button13.TabIndex = 3;
            button13.Text = "Ejemplo 2";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Presionando_boton_ejemplo_2;
            // 
            // button12
            // 
            button12.Location = new Point(12, 213);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 2;
            button12.Text = "Ejemplo 1";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Clickeado;
            button12.MouseMove += Movimiento_mouse_en_ejemplo_1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(55, 39);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 1;
            // 
            // button11
            // 
            button11.Location = new Point(64, 107);
            button11.Name = "button11";
            button11.Size = new Size(91, 23);
            button11.TabIndex = 0;
            button11.Text = "Abrir Form2";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button19
            // 
            button19.Location = new Point(513, 325);
            button19.Name = "button19";
            button19.Size = new Size(75, 23);
            button19.TabIndex = 6;
            button19.Text = "Rehacer";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 513);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Ventana principal";
            Load += Form1_Load;
            KeyUp += tecla_presionada;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblRes;
        private TextBox txtNum2;
        public TextBox txtNum1;
        private Button button1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Button button2;
        private TextBox txtValorLista;
        private Label label2;
        private Button button3;
        private RichTextBox txtLista1;
        private GroupBox groupBox3;
        private Panel panel2;
        private RichTextBox txtContenidoPila;
        private Label label4;
        private TextBox txtSacado;
        private Button button5;
        private Button button4;
        private TextBox txtDepto;
        private Label label3;
        private GroupBox groupBox4;
        private Panel panel3;
        private RichTextBox txtCola;
        private TextBox txtSacadoCola;
        private Label label6;
        private Button button7;
        private Button button6;
        private TextBox txtCliente;
        private Label label5;
        private TabPage tabPage3;
        private GroupBox groupBox5;
        private RichTextBox richTextBox1;
        private Button button8;
        private TextBox textBox5;
        private Label label11;
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox1;
        private Label label7;
        private GroupBox groupBox6;
        private Panel panel5;
        private Panel panel4;
        private TextBox txtPrimitivaCopiaMostrar;
        private Label label13;
        private TextBox txtPrimitivaOriginalMostrar;
        private Label label12;
        private TextBox txtPrimitivaOriginal;
        private Button button9;
        private TextBox txtObjetoCopiaMostrar;
        private Label label14;
        private TextBox txtObjetoOriginalMostrar;
        private Label label15;
        private Button button10;
        private TabPage tabPage4;
        private Button button11;
        private TextBox textBox6;
        private Button button12;
        private Button button13;
        private GroupBox groupBox7;
        private Panel lienzo;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button18;
        private Button button19;
    }
}