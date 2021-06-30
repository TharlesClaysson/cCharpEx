
namespace Ex16
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
            this.TB_Numero = new System.Windows.Forms.TextBox();
            this.B_insere = new System.Windows.Forms.Button();
            this.B_remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TB_Numero
            // 
            this.TB_Numero.Location = new System.Drawing.Point(166, 88);
            this.TB_Numero.Name = "TB_Numero";
            this.TB_Numero.Size = new System.Drawing.Size(100, 20);
            this.TB_Numero.TabIndex = 0;
            // 
            // B_insere
            // 
            this.B_insere.Location = new System.Drawing.Point(166, 148);
            this.B_insere.Name = "B_insere";
            this.B_insere.Size = new System.Drawing.Size(75, 23);
            this.B_insere.TabIndex = 1;
            this.B_insere.Text = "inserir";
            this.B_insere.UseVisualStyleBackColor = true;
            this.B_insere.Click += new System.EventHandler(this.B_insere_Click);
            // 
            // B_remove
            // 
            this.B_remove.Location = new System.Drawing.Point(516, 85);
            this.B_remove.Name = "B_remove";
            this.B_remove.Size = new System.Drawing.Size(75, 23);
            this.B_remove.TabIndex = 2;
            this.B_remove.Text = "Remover";
            this.B_remove.UseVisualStyleBackColor = true;
            this.B_remove.Click += new System.EventHandler(this.B_remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Números removidos";
            // 
            // LB
            // 
            this.LB.FormattingEnabled = true;
            this.LB.Location = new System.Drawing.Point(516, 199);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(120, 95);
            this.LB.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_remove);
            this.Controls.Add(this.B_insere);
            this.Controls.Add(this.TB_Numero);
            this.Name = "Form1";
            this.Text = "introdução a lista linear encadeada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Numero;
        private System.Windows.Forms.Button B_insere;
        private System.Windows.Forms.Button B_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LB;
    }
}

