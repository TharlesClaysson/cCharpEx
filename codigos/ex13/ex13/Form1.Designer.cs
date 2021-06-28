
namespace ex13
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
            this.B_Insere = new System.Windows.Forms.Button();
            this.B_Exibe = new System.Windows.Forms.Button();
            this.B_Divide = new System.Windows.Forms.Button();
            this.TB_valor = new System.Windows.Forms.TextBox();
            this.TB_metade = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_Insere
            // 
            this.B_Insere.Location = new System.Drawing.Point(248, 57);
            this.B_Insere.Name = "B_Insere";
            this.B_Insere.Size = new System.Drawing.Size(119, 23);
            this.B_Insere.TabIndex = 0;
            this.B_Insere.Text = "Insere na fila";
            this.B_Insere.UseVisualStyleBackColor = true;
            this.B_Insere.Click += new System.EventHandler(this.B_Insere_Click);
            // 
            // B_Exibe
            // 
            this.B_Exibe.Location = new System.Drawing.Point(162, 160);
            this.B_Exibe.Name = "B_Exibe";
            this.B_Exibe.Size = new System.Drawing.Size(109, 23);
            this.B_Exibe.TabIndex = 1;
            this.B_Exibe.Text = "Exibe as duas filas";
            this.B_Exibe.UseVisualStyleBackColor = true;
            this.B_Exibe.Click += new System.EventHandler(this.B_Exibe_Click);
            // 
            // B_Divide
            // 
            this.B_Divide.Location = new System.Drawing.Point(248, 106);
            this.B_Divide.Name = "B_Divide";
            this.B_Divide.Size = new System.Drawing.Size(119, 23);
            this.B_Divide.TabIndex = 2;
            this.B_Divide.Text = "Divide em duas filas";
            this.B_Divide.UseVisualStyleBackColor = true;
            this.B_Divide.Click += new System.EventHandler(this.B_Divide_Click);
            // 
            // TB_valor
            // 
            this.TB_valor.Location = new System.Drawing.Point(92, 60);
            this.TB_valor.Name = "TB_valor";
            this.TB_valor.Size = new System.Drawing.Size(100, 20);
            this.TB_valor.TabIndex = 3;
            // 
            // TB_metade
            // 
            this.TB_metade.Location = new System.Drawing.Point(92, 109);
            this.TB_metade.Name = "TB_metade";
            this.TB_metade.Size = new System.Drawing.Size(100, 20);
            this.TB_metade.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(71, 231);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(248, 231);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor p";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fila de números menores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fila de números maiores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TB_metade);
            this.Controls.Add(this.TB_valor);
            this.Controls.Add(this.B_Divide);
            this.Controls.Add(this.B_Exibe);
            this.Controls.Add(this.B_Insere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Insere;
        private System.Windows.Forms.Button B_Exibe;
        private System.Windows.Forms.Button B_Divide;
        private System.Windows.Forms.TextBox TB_valor;
        private System.Windows.Forms.TextBox TB_metade;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

