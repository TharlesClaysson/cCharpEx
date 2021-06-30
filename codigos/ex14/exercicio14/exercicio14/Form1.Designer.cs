
namespace exercicio14
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
            this.TB_Numero = new System.Windows.Forms.TextBox();
            this.B_Insere = new System.Windows.Forms.Button();
            this.B_Processa = new System.Windows.Forms.Button();
            this.LB_Resultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultados";
            // 
            // TB_Numero
            // 
            this.TB_Numero.Location = new System.Drawing.Point(137, 47);
            this.TB_Numero.Name = "TB_Numero";
            this.TB_Numero.Size = new System.Drawing.Size(100, 20);
            this.TB_Numero.TabIndex = 2;
            // 
            // B_Insere
            // 
            this.B_Insere.Location = new System.Drawing.Point(286, 40);
            this.B_Insere.Name = "B_Insere";
            this.B_Insere.Size = new System.Drawing.Size(91, 32);
            this.B_Insere.TabIndex = 3;
            this.B_Insere.Text = "Insere na fila";
            this.B_Insere.UseVisualStyleBackColor = true;
            this.B_Insere.Click += new System.EventHandler(this.B_Insere_Click);
            // 
            // B_Processa
            // 
            this.B_Processa.Location = new System.Drawing.Point(137, 114);
            this.B_Processa.Name = "B_Processa";
            this.B_Processa.Size = new System.Drawing.Size(96, 32);
            this.B_Processa.TabIndex = 4;
            this.B_Processa.Text = "Processamento";
            this.B_Processa.UseVisualStyleBackColor = true;
            this.B_Processa.Click += new System.EventHandler(this.B_Processa_Click);
            // 
            // LB_Resultados
            // 
            this.LB_Resultados.FormattingEnabled = true;
            this.LB_Resultados.Location = new System.Drawing.Point(137, 198);
            this.LB_Resultados.Name = "LB_Resultados";
            this.LB_Resultados.Size = new System.Drawing.Size(120, 95);
            this.LB_Resultados.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 337);
            this.Controls.Add(this.LB_Resultados);
            this.Controls.Add(this.B_Processa);
            this.Controls.Add(this.B_Insere);
            this.Controls.Add(this.TB_Numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Estatística";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Numero;
        private System.Windows.Forms.Button B_Insere;
        private System.Windows.Forms.Button B_Processa;
        private System.Windows.Forms.ListBox LB_Resultados;
    }
}

