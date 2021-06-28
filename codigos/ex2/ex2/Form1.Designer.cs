
namespace ex2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Base = new System.Windows.Forms.TextBox();
            this.TB_Expoente = new System.Windows.Forms.TextBox();
            this.Respostas = new System.Windows.Forms.ListBox();
            this.B_calcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.B_Cubos = new System.Windows.Forms.Button();
            this.TB_Cubos = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.B_Mdc = new System.Windows.Forms.Button();
            this.TB_Y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_X = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.B_Fib = new System.Windows.Forms.Button();
            this.TB_Fibonacci = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.B_Bin = new System.Windows.Forms.Button();
            this.TB_Binario = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expoente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // TB_Base
            // 
            this.TB_Base.Location = new System.Drawing.Point(76, 22);
            this.TB_Base.Name = "TB_Base";
            this.TB_Base.Size = new System.Drawing.Size(100, 20);
            this.TB_Base.TabIndex = 3;
            // 
            // TB_Expoente
            // 
            this.TB_Expoente.Location = new System.Drawing.Point(76, 48);
            this.TB_Expoente.Name = "TB_Expoente";
            this.TB_Expoente.Size = new System.Drawing.Size(100, 20);
            this.TB_Expoente.TabIndex = 4;
            // 
            // Respostas
            // 
            this.Respostas.FormattingEnabled = true;
            this.Respostas.Location = new System.Drawing.Point(516, 224);
            this.Respostas.Name = "Respostas";
            this.Respostas.Size = new System.Drawing.Size(145, 134);
            this.Respostas.TabIndex = 5;
            // 
            // B_calcular
            // 
            this.B_calcular.Location = new System.Drawing.Point(258, 29);
            this.B_calcular.Name = "B_calcular";
            this.B_calcular.Size = new System.Drawing.Size(100, 23);
            this.B_calcular.TabIndex = 6;
            this.B_calcular.Text = "Processa";
            this.B_calcular.UseVisualStyleBackColor = true;
            this.B_calcular.Click += new System.EventHandler(this.B_calcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.B_calcular);
            this.groupBox1.Controls.Add(this.TB_Expoente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_Base);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 111);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Potência";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.B_Cubos);
            this.groupBox2.Controls.Add(this.TB_Cubos);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 95);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cubos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "n";
            // 
            // B_Cubos
            // 
            this.B_Cubos.Location = new System.Drawing.Point(258, 50);
            this.B_Cubos.Name = "B_Cubos";
            this.B_Cubos.Size = new System.Drawing.Size(100, 23);
            this.B_Cubos.TabIndex = 6;
            this.B_Cubos.Text = "Processa";
            this.B_Cubos.UseVisualStyleBackColor = true;
            this.B_Cubos.Click += new System.EventHandler(this.B_Cubos_Click);
            // 
            // TB_Cubos
            // 
            this.TB_Cubos.Location = new System.Drawing.Point(98, 50);
            this.TB_Cubos.Name = "TB_Cubos";
            this.TB_Cubos.Size = new System.Drawing.Size(100, 20);
            this.TB_Cubos.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.B_Mdc);
            this.groupBox3.Controls.Add(this.TB_Y);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TB_X);
            this.groupBox3.Location = new System.Drawing.Point(12, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 106);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Máximo Divisor Comum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "X";
            // 
            // B_Mdc
            // 
            this.B_Mdc.Location = new System.Drawing.Point(258, 52);
            this.B_Mdc.Name = "B_Mdc";
            this.B_Mdc.Size = new System.Drawing.Size(100, 23);
            this.B_Mdc.TabIndex = 6;
            this.B_Mdc.Text = "Processa";
            this.B_Mdc.UseVisualStyleBackColor = true;
            this.B_Mdc.Click += new System.EventHandler(this.B_Mdc_Click);
            // 
            // TB_Y
            // 
            this.TB_Y.Location = new System.Drawing.Point(98, 71);
            this.TB_Y.Name = "TB_Y";
            this.TB_Y.Size = new System.Drawing.Size(100, 20);
            this.TB_Y.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Y";
            // 
            // TB_X
            // 
            this.TB_X.Location = new System.Drawing.Point(98, 29);
            this.TB_X.Name = "TB_X";
            this.TB_X.Size = new System.Drawing.Size(100, 20);
            this.TB_X.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.B_Fib);
            this.groupBox4.Controls.Add(this.TB_Fibonacci);
            this.groupBox4.Location = new System.Drawing.Point(12, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 93);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Série Fibonacci";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "n";
            // 
            // B_Fib
            // 
            this.B_Fib.Location = new System.Drawing.Point(258, 46);
            this.B_Fib.Name = "B_Fib";
            this.B_Fib.Size = new System.Drawing.Size(100, 23);
            this.B_Fib.TabIndex = 6;
            this.B_Fib.Text = "Processa";
            this.B_Fib.UseVisualStyleBackColor = true;
            this.B_Fib.Click += new System.EventHandler(this.B_Fib_Click);
            // 
            // TB_Fibonacci
            // 
            this.TB_Fibonacci.Location = new System.Drawing.Point(98, 46);
            this.TB_Fibonacci.Name = "TB_Fibonacci";
            this.TB_Fibonacci.Size = new System.Drawing.Size(100, 20);
            this.TB_Fibonacci.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.B_Bin);
            this.groupBox5.Controls.Add(this.TB_Binario);
            this.groupBox5.Location = new System.Drawing.Point(430, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(358, 111);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Inteiro para binário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Número";
            // 
            // B_Bin
            // 
            this.B_Bin.Location = new System.Drawing.Point(196, 19);
            this.B_Bin.Name = "B_Bin";
            this.B_Bin.Size = new System.Drawing.Size(100, 23);
            this.B_Bin.TabIndex = 6;
            this.B_Bin.Text = "Processa";
            this.B_Bin.UseVisualStyleBackColor = true;
            this.B_Bin.Click += new System.EventHandler(this.B_Bin_Click);
            // 
            // TB_Binario
            // 
            this.TB_Binario.Location = new System.Drawing.Point(76, 22);
            this.TB_Binario.Name = "TB_Binario";
            this.TB_Binario.Size = new System.Drawing.Size(100, 20);
            this.TB_Binario.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Respostas);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Base;
        private System.Windows.Forms.TextBox TB_Expoente;
        private System.Windows.Forms.ListBox Respostas;
        private System.Windows.Forms.Button B_calcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_Cubos;
        private System.Windows.Forms.TextBox TB_Cubos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button B_Mdc;
        private System.Windows.Forms.TextBox TB_Y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_X;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button B_Fib;
        private System.Windows.Forms.TextBox TB_Fibonacci;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button B_Bin;
        private System.Windows.Forms.TextBox TB_Binario;
    }
}

