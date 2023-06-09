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
            groupBox5 = new GroupBox();
            label7 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            textBox3 = new TextBox();
            label10 = new Label();
            textBox4 = new TextBox();
            label11 = new Label();
            textBox5 = new TextBox();
            button8 = new Button();
            richTextBox1 = new RichTextBox();
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
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(684, 357);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(676, 329);
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
            tabPage2.Size = new Size(676, 329);
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
            tabPage3.Controls.Add(groupBox5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(676, 329);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Valor-Referencia";
            tabPage3.UseVisualStyleBackColor = true;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 13);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 0;
            label7.Text = "Usuario:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
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
            // textBox2
            // 
            textBox2.Location = new Point(60, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
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
            // textBox3
            // 
            textBox3.Location = new Point(60, 68);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 1;
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
            // textBox4
            // 
            textBox4.Location = new Point(60, 97);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 1;
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
            // textBox5
            // 
            textBox5.Location = new Point(60, 126);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 1;
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 184);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(173, 132);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 373);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Ventana principal";
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
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
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
        private TextBox txtNum1;
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
    }
}