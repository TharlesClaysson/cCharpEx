
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TB_entrada = new System.Windows.Forms.MaskedTextBox();
            this.TB_saida = new System.Windows.Forms.MaskedTextBox();
            this.B_processa = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "entrada de dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "saida de dados";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TB_entrada
            // 
            this.TB_entrada.Location = new System.Drawing.Point(198, 47);
            this.TB_entrada.Name = "TB_entrada";
            this.TB_entrada.Size = new System.Drawing.Size(100, 20);
            this.TB_entrada.TabIndex = 3;
            this.TB_entrada.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // TB_saida
            // 
            this.TB_saida.Enabled = false;
            this.TB_saida.Location = new System.Drawing.Point(181, 346);
            this.TB_saida.Name = "TB_saida";
            this.TB_saida.Size = new System.Drawing.Size(248, 20);
            this.TB_saida.TabIndex = 4;
            this.TB_saida.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TB_saida_MaskInputRejected);
            // 
            // B_processa
            // 
            this.B_processa.Location = new System.Drawing.Point(198, 160);
            this.B_processa.Name = "B_processa";
            this.B_processa.Size = new System.Drawing.Size(120, 39);
            this.B_processa.TabIndex = 5;
            this.B_processa.Text = "processo";
            this.B_processa.UseVisualStyleBackColor = true;
            this.B_processa.Click += new System.EventHandler(this.B_processa_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(508, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(113, 199);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.B_processa);
            this.Controls.Add(this.TB_saida);
            this.Controls.Add(this.TB_entrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox TB_entrada;
        private System.Windows.Forms.MaskedTextBox TB_saida;
        private System.Windows.Forms.Button B_processa;
        private System.Windows.Forms.ListBox listBox1;
    }
}

