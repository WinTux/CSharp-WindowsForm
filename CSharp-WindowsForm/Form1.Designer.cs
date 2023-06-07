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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(501, 357);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(493, 329);
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(493, 329);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Estructuras de datos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 373);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Ventana principal";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}