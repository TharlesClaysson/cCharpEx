
namespace Ex24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Insere = new System.Windows.Forms.Button();
            this.B_Remove = new System.Windows.Forms.Button();
            this.TB_Insere = new System.Windows.Forms.TextBox();
            this.B_Pesquisa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LB_Resultados = new System.Windows.Forms.ListBox();
            this.B_Exibir = new System.Windows.Forms.Button();
            this.RB_Pos = new System.Windows.Forms.RadioButton();
            this.RB_Pre = new System.Windows.Forms.RadioButton();
            this.RB_Ordem = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.B_Insere);
            this.groupBox1.Controls.Add(this.B_Remove);
            this.groupBox1.Controls.Add(this.TB_Insere);
            this.groupBox1.Controls.Add(this.B_Pesquisa);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir, Pesquisar e Remover";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor";
            // 
            // B_Insere
            // 
            this.B_Insere.BackColor = System.Drawing.SystemColors.ControlText;
            this.B_Insere.ForeColor = System.Drawing.Color.Transparent;
            this.B_Insere.ImageKey = "(nenhum/a)";
            this.B_Insere.Location = new System.Drawing.Point(17, 118);
            this.B_Insere.Name = "B_Insere";
            this.B_Insere.Size = new System.Drawing.Size(75, 23);
            this.B_Insere.TabIndex = 1;
            this.B_Insere.Text = "Inserir";
            this.B_Insere.UseVisualStyleBackColor = false;
            this.B_Insere.Click += new System.EventHandler(this.B_Insere_Click);
            // 
            // B_Remove
            // 
            this.B_Remove.BackColor = System.Drawing.SystemColors.Desktop;
            this.B_Remove.Location = new System.Drawing.Point(337, 118);
            this.B_Remove.Name = "B_Remove";
            this.B_Remove.Size = new System.Drawing.Size(75, 23);
            this.B_Remove.TabIndex = 4;
            this.B_Remove.Text = "Remover";
            this.B_Remove.UseVisualStyleBackColor = false;
            this.B_Remove.Click += new System.EventHandler(this.B_Remove_Click);
            // 
            // TB_Insere
            // 
            this.TB_Insere.BackColor = System.Drawing.Color.LightGray;
            this.TB_Insere.Location = new System.Drawing.Point(282, 51);
            this.TB_Insere.Name = "TB_Insere";
            this.TB_Insere.Size = new System.Drawing.Size(130, 20);
            this.TB_Insere.TabIndex = 0;
            // 
            // B_Pesquisa
            // 
            this.B_Pesquisa.BackColor = System.Drawing.SystemColors.Desktop;
            this.B_Pesquisa.Location = new System.Drawing.Point(181, 118);
            this.B_Pesquisa.Name = "B_Pesquisa";
            this.B_Pesquisa.Size = new System.Drawing.Size(75, 23);
            this.B_Pesquisa.TabIndex = 3;
            this.B_Pesquisa.Text = "Pesquisar";
            this.B_Pesquisa.UseVisualStyleBackColor = false;
            this.B_Pesquisa.Click += new System.EventHandler(this.B_Pesquisa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.LB_Resultados);
            this.groupBox2.Controls.Add(this.B_Exibir);
            this.groupBox2.Controls.Add(this.RB_Pos);
            this.groupBox2.Controls.Add(this.RB_Pre);
            this.groupBox2.Controls.Add(this.RB_Ordem);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exibir";
            // 
            // LB_Resultados
            // 
            this.LB_Resultados.BackColor = System.Drawing.Color.White;
            this.LB_Resultados.FormattingEnabled = true;
            this.LB_Resultados.Location = new System.Drawing.Point(17, 130);
            this.LB_Resultados.Name = "LB_Resultados";
            this.LB_Resultados.Size = new System.Drawing.Size(75, 160);
            this.LB_Resultados.TabIndex = 6;
            // 
            // B_Exibir
            // 
            this.B_Exibir.BackColor = System.Drawing.SystemColors.Desktop;
            this.B_Exibir.Location = new System.Drawing.Point(17, 77);
            this.B_Exibir.Name = "B_Exibir";
            this.B_Exibir.Size = new System.Drawing.Size(75, 23);
            this.B_Exibir.TabIndex = 5;
            this.B_Exibir.Text = "Exibir";
            this.B_Exibir.UseVisualStyleBackColor = false;
            this.B_Exibir.Click += new System.EventHandler(this.B_Exibir_Click);
            // 
            // RB_Pos
            // 
            this.RB_Pos.AutoSize = true;
            this.RB_Pos.BackColor = System.Drawing.Color.Transparent;
            this.RB_Pos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.RB_Pos.Location = new System.Drawing.Point(181, 28);
            this.RB_Pos.Name = "RB_Pos";
            this.RB_Pos.Size = new System.Drawing.Size(77, 17);
            this.RB_Pos.TabIndex = 2;
            this.RB_Pos.TabStop = true;
            this.RB_Pos.Text = "Pós Ordem";
            this.RB_Pos.UseVisualStyleBackColor = false;
            // 
            // RB_Pre
            // 
            this.RB_Pre.AutoSize = true;
            this.RB_Pre.BackColor = System.Drawing.Color.Transparent;
            this.RB_Pre.Location = new System.Drawing.Point(98, 28);
            this.RB_Pre.Name = "RB_Pre";
            this.RB_Pre.Size = new System.Drawing.Size(75, 17);
            this.RB_Pre.TabIndex = 1;
            this.RB_Pre.TabStop = true;
            this.RB_Pre.Text = "Pré Ordem";
            this.RB_Pre.UseVisualStyleBackColor = false;
            // 
            // RB_Ordem
            // 
            this.RB_Ordem.AutoSize = true;
            this.RB_Ordem.BackColor = System.Drawing.Color.Transparent;
            this.RB_Ordem.Location = new System.Drawing.Point(18, 28);
            this.RB_Ordem.Name = "RB_Ordem";
            this.RB_Ordem.Size = new System.Drawing.Size(74, 17);
            this.RB_Ordem.TabIndex = 0;
            this.RB_Ordem.TabStop = true;
            this.RB_Ordem.Text = "Em Ordem";
            this.RB_Ordem.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(466, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Árvore Binária";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_Insere;
        private System.Windows.Forms.RadioButton RB_Pos;
        private System.Windows.Forms.RadioButton RB_Pre;
        private System.Windows.Forms.RadioButton RB_Ordem;
        private System.Windows.Forms.Button B_Insere;
        private System.Windows.Forms.Button B_Remove;
        private System.Windows.Forms.Button B_Pesquisa;
        private System.Windows.Forms.Button B_Exibir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_Resultados;
    }
}

