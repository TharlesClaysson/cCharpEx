
namespace revisao
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
            this.TB_Entrada = new System.Windows.Forms.TextBox();
            this.TB_Saida = new System.Windows.Forms.TextBox();
            this.B_Processa = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada de dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saída de dados";
            // 
            // TB_Entrada
            // 
            this.TB_Entrada.Location = new System.Drawing.Point(177, 56);
            this.TB_Entrada.Name = "TB_Entrada";
            this.TB_Entrada.Size = new System.Drawing.Size(128, 20);
            this.TB_Entrada.TabIndex = 2;
            this.TB_Entrada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TB_Saida
            // 
            this.TB_Saida.Location = new System.Drawing.Point(177, 205);
            this.TB_Saida.Name = "TB_Saida";
            this.TB_Saida.Size = new System.Drawing.Size(197, 20);
            this.TB_Saida.TabIndex = 3;
            // 
            // B_Processa
            // 
            this.B_Processa.Location = new System.Drawing.Point(147, 112);
            this.B_Processa.Name = "B_Processa";
            this.B_Processa.Size = new System.Drawing.Size(90, 47);
            this.B_Processa.TabIndex = 4;
            this.B_Processa.Text = "Processa";
            this.B_Processa.UseVisualStyleBackColor = true;
            this.B_Processa.Click += new System.EventHandler(this.B_Processa_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(493, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(141, 173);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.B_Processa);
            this.Controls.Add(this.TB_Saida);
            this.Controls.Add(this.TB_Entrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Revisão de Programação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Entrada;
        private System.Windows.Forms.TextBox TB_Saida;
        private System.Windows.Forms.Button B_Processa;
        private System.Windows.Forms.ListBox listBox1;
    }
}

