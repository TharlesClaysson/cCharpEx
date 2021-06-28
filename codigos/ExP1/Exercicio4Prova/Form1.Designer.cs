
namespace Exercicio4Prova
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
            this.TB_Valor = new System.Windows.Forms.TextBox();
            this.B_Insere = new System.Windows.Forms.Button();
            this.B_Exibe = new System.Windows.Forms.Button();
            this.LB_Result = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // TB_Valor
            // 
            this.TB_Valor.Location = new System.Drawing.Point(120, 48);
            this.TB_Valor.Name = "TB_Valor";
            this.TB_Valor.Size = new System.Drawing.Size(100, 20);
            this.TB_Valor.TabIndex = 1;
            // 
            // B_Insere
            // 
            this.B_Insere.Location = new System.Drawing.Point(245, 45);
            this.B_Insere.Name = "B_Insere";
            this.B_Insere.Size = new System.Drawing.Size(75, 23);
            this.B_Insere.TabIndex = 2;
            this.B_Insere.Text = "Inserir";
            this.B_Insere.UseVisualStyleBackColor = true;
            this.B_Insere.Click += new System.EventHandler(this.B_Insere_Click);
            // 
            // B_Exibe
            // 
            this.B_Exibe.Location = new System.Drawing.Point(120, 96);
            this.B_Exibe.Name = "B_Exibe";
            this.B_Exibe.Size = new System.Drawing.Size(75, 23);
            this.B_Exibe.TabIndex = 3;
            this.B_Exibe.Text = "Exibir";
            this.B_Exibe.UseVisualStyleBackColor = true;
            this.B_Exibe.Click += new System.EventHandler(this.B_Exibe_Click);
            // 
            // LB_Result
            // 
            this.LB_Result.FormattingEnabled = true;
            this.LB_Result.Location = new System.Drawing.Point(120, 153);
            this.LB_Result.Name = "LB_Result";
            this.LB_Result.Size = new System.Drawing.Size(120, 95);
            this.LB_Result.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_Result);
            this.Controls.Add(this.B_Exibe);
            this.Controls.Add(this.B_Insere);
            this.Controls.Add(this.TB_Valor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Valor;
        private System.Windows.Forms.Button B_Insere;
        private System.Windows.Forms.Button B_Exibe;
        private System.Windows.Forms.ListBox LB_Result;
    }
}

