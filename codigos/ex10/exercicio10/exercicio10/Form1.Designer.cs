
namespace exercicio10
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
            this.TB_Frase = new System.Windows.Forms.TextBox();
            this.TB_PalavrasInv = new System.Windows.Forms.TextBox();
            this.B_Processa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite uma frase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frase com palavras invertidas";
            // 
            // TB_Frase
            // 
            this.TB_Frase.Location = new System.Drawing.Point(161, 45);
            this.TB_Frase.Name = "TB_Frase";
            this.TB_Frase.Size = new System.Drawing.Size(174, 20);
            this.TB_Frase.TabIndex = 2;
            // 
            // TB_PalavrasInv
            // 
            this.TB_PalavrasInv.Location = new System.Drawing.Point(192, 185);
            this.TB_PalavrasInv.Name = "TB_PalavrasInv";
            this.TB_PalavrasInv.Size = new System.Drawing.Size(168, 20);
            this.TB_PalavrasInv.TabIndex = 3;
            // 
            // B_Processa
            // 
            this.B_Processa.Location = new System.Drawing.Point(113, 105);
            this.B_Processa.Name = "B_Processa";
            this.B_Processa.Size = new System.Drawing.Size(129, 36);
            this.B_Processa.TabIndex = 4;
            this.B_Processa.Text = "Processa";
            this.B_Processa.UseVisualStyleBackColor = true;
            this.B_Processa.Click += new System.EventHandler(this.B_Processa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 299);
            this.Controls.Add(this.B_Processa);
            this.Controls.Add(this.TB_PalavrasInv);
            this.Controls.Add(this.TB_Frase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Inverte palavras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Frase;
        private System.Windows.Forms.TextBox TB_PalavrasInv;
        private System.Windows.Forms.Button B_Processa;
    }
}

