
namespace exercicio1_recurcividade
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_Impares = new System.Windows.Forms.Button();
            this.B_Somatoria = new System.Windows.Forms.Button();
            this.B_Decrescente = new System.Windows.Forms.Button();
            this.B_Crescente = new System.Windows.Forms.Button();
            this.TB_NumFinal = new System.Windows.Forms.TextBox();
            this.TB_NumInicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.B_Insere = new System.Windows.Forms.Button();
            this.B_Soma = new System.Windows.Forms.Button();
            this.TB_Numero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_Resultados = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_Impares);
            this.groupBox1.Controls.Add(this.B_Somatoria);
            this.groupBox1.Controls.Add(this.B_Decrescente);
            this.groupBox1.Controls.Add(this.B_Crescente);
            this.groupBox1.Controls.Add(this.TB_NumFinal);
            this.groupBox1.Controls.Add(this.TB_NumInicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(81, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "algoritimos sem vetor";
            // 
            // B_Impares
            // 
            this.B_Impares.Location = new System.Drawing.Point(356, 112);
            this.B_Impares.Name = "B_Impares";
            this.B_Impares.Size = new System.Drawing.Size(75, 23);
            this.B_Impares.TabIndex = 7;
            this.B_Impares.Text = "ímpares";
            this.B_Impares.UseVisualStyleBackColor = true;
            this.B_Impares.Click += new System.EventHandler(this.B_Impares_Click);
            // 
            // B_Somatoria
            // 
            this.B_Somatoria.Location = new System.Drawing.Point(264, 112);
            this.B_Somatoria.Name = "B_Somatoria";
            this.B_Somatoria.Size = new System.Drawing.Size(75, 23);
            this.B_Somatoria.TabIndex = 6;
            this.B_Somatoria.Text = "somatória";
            this.B_Somatoria.UseVisualStyleBackColor = true;
            this.B_Somatoria.Click += new System.EventHandler(this.B_Somatoria_Click);
            // 
            // B_Decrescente
            // 
            this.B_Decrescente.Location = new System.Drawing.Point(162, 112);
            this.B_Decrescente.Name = "B_Decrescente";
            this.B_Decrescente.Size = new System.Drawing.Size(75, 23);
            this.B_Decrescente.TabIndex = 5;
            this.B_Decrescente.Text = "decrescente";
            this.B_Decrescente.UseVisualStyleBackColor = true;
            this.B_Decrescente.Click += new System.EventHandler(this.B_Decrescente_Click);
            // 
            // B_Crescente
            // 
            this.B_Crescente.Location = new System.Drawing.Point(25, 112);
            this.B_Crescente.Name = "B_Crescente";
            this.B_Crescente.Size = new System.Drawing.Size(75, 24);
            this.B_Crescente.TabIndex = 4;
            this.B_Crescente.Text = "crescente";
            this.B_Crescente.UseVisualStyleBackColor = true;
            this.B_Crescente.Click += new System.EventHandler(this.B_Crescente_Click);
            // 
            // TB_NumFinal
            // 
            this.TB_NumFinal.Location = new System.Drawing.Point(162, 61);
            this.TB_NumFinal.Name = "TB_NumFinal";
            this.TB_NumFinal.Size = new System.Drawing.Size(100, 20);
            this.TB_NumFinal.TabIndex = 3;
            // 
            // TB_NumInicial
            // 
            this.TB_NumInicial.Location = new System.Drawing.Point(25, 61);
            this.TB_NumInicial.Name = "TB_NumInicial";
            this.TB_NumInicial.Size = new System.Drawing.Size(100, 20);
            this.TB_NumInicial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "número final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "numero inicial";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.B_Insere);
            this.groupBox2.Controls.Add(this.B_Soma);
            this.groupBox2.Controls.Add(this.TB_Numero);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(81, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "algoritimos com vetor";
            // 
            // B_Insere
            // 
            this.B_Insere.Location = new System.Drawing.Point(229, 61);
            this.B_Insere.Name = "B_Insere";
            this.B_Insere.Size = new System.Drawing.Size(110, 23);
            this.B_Insere.TabIndex = 6;
            this.B_Insere.Text = "insere no vetor";
            this.B_Insere.UseVisualStyleBackColor = true;
            this.B_Insere.Click += new System.EventHandler(this.B_Insere_Click);
            // 
            // B_Soma
            // 
            this.B_Soma.Location = new System.Drawing.Point(356, 59);
            this.B_Soma.Name = "B_Soma";
            this.B_Soma.Size = new System.Drawing.Size(75, 23);
            this.B_Soma.TabIndex = 4;
            this.B_Soma.Text = "soma vetor";
            this.B_Soma.UseVisualStyleBackColor = true;
            this.B_Soma.Click += new System.EventHandler(this.B_Soma_Click);
            // 
            // TB_Numero
            // 
            this.TB_Numero.Location = new System.Drawing.Point(107, 63);
            this.TB_Numero.Name = "TB_Numero";
            this.TB_Numero.Size = new System.Drawing.Size(100, 20);
            this.TB_Numero.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "resultados";
            // 
            // LB_Resultados
            // 
            this.LB_Resultados.FormattingEnabled = true;
            this.LB_Resultados.Location = new System.Drawing.Point(580, 62);
            this.LB_Resultados.Name = "LB_Resultados";
            this.LB_Resultados.Size = new System.Drawing.Size(120, 212);
            this.LB_Resultados.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_Resultados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button B_Impares;
        private System.Windows.Forms.Button B_Somatoria;
        private System.Windows.Forms.Button B_Decrescente;
        private System.Windows.Forms.Button B_Crescente;
        private System.Windows.Forms.TextBox TB_NumFinal;
        private System.Windows.Forms.TextBox TB_NumInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button B_Insere;
        private System.Windows.Forms.Button B_Soma;
        private System.Windows.Forms.TextBox TB_Numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LB_Resultados;
    }
}

