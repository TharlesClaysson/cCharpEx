
namespace exercicio26
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Nome = new System.Windows.Forms.TextBox();
            this.TB_Nota = new System.Windows.Forms.TextBox();
            this.B_Insere = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Posicao = new System.Windows.Forms.TextBox();
            this.TB_Email_R = new System.Windows.Forms.TextBox();
            this.TB_Nome_R = new System.Windows.Forms.TextBox();
            this.TB_Nota_R = new System.Windows.Forms.TextBox();
            this.B_Recupera = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.L_Qtd = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(26, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(469, 358);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TB_Email);
            this.tabPage1.Controls.Add(this.TB_Nome);
            this.tabPage1.Controls.Add(this.TB_Nota);
            this.tabPage1.Controls.Add(this.B_Insere);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(461, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Incluir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(99, 175);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(100, 20);
            this.TB_Email.TabIndex = 6;
            // 
            // TB_Nome
            // 
            this.TB_Nome.Location = new System.Drawing.Point(99, 114);
            this.TB_Nome.Name = "TB_Nome";
            this.TB_Nome.Size = new System.Drawing.Size(223, 20);
            this.TB_Nome.TabIndex = 5;
            // 
            // TB_Nota
            // 
            this.TB_Nota.Location = new System.Drawing.Point(99, 54);
            this.TB_Nota.Name = "TB_Nota";
            this.TB_Nota.Size = new System.Drawing.Size(74, 20);
            this.TB_Nota.TabIndex = 4;
            // 
            // B_Insere
            // 
            this.B_Insere.Location = new System.Drawing.Point(183, 240);
            this.B_Insere.Name = "B_Insere";
            this.B_Insere.Size = new System.Drawing.Size(75, 23);
            this.B_Insere.TabIndex = 3;
            this.B_Insere.Text = "Inserir";
            this.B_Insere.UseVisualStyleBackColor = true;
            this.B_Insere.Click += new System.EventHandler(this.B_Insere_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TB_Posicao);
            this.tabPage2.Controls.Add(this.TB_Email_R);
            this.tabPage2.Controls.Add(this.TB_Nome_R);
            this.tabPage2.Controls.Add(this.TB_Nota_R);
            this.tabPage2.Controls.Add(this.B_Recupera);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(461, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recuperar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Posição no vetor";
            // 
            // TB_Posicao
            // 
            this.TB_Posicao.Location = new System.Drawing.Point(177, 241);
            this.TB_Posicao.Name = "TB_Posicao";
            this.TB_Posicao.Size = new System.Drawing.Size(100, 20);
            this.TB_Posicao.TabIndex = 14;
            // 
            // TB_Email_R
            // 
            this.TB_Email_R.Location = new System.Drawing.Point(130, 173);
            this.TB_Email_R.Name = "TB_Email_R";
            this.TB_Email_R.Size = new System.Drawing.Size(100, 20);
            this.TB_Email_R.TabIndex = 13;
            // 
            // TB_Nome_R
            // 
            this.TB_Nome_R.Location = new System.Drawing.Point(130, 112);
            this.TB_Nome_R.Name = "TB_Nome_R";
            this.TB_Nome_R.Size = new System.Drawing.Size(223, 20);
            this.TB_Nome_R.TabIndex = 12;
            // 
            // TB_Nota_R
            // 
            this.TB_Nota_R.Location = new System.Drawing.Point(130, 52);
            this.TB_Nota_R.Name = "TB_Nota_R";
            this.TB_Nota_R.Size = new System.Drawing.Size(74, 20);
            this.TB_Nota_R.TabIndex = 11;
            // 
            // B_Recupera
            // 
            this.B_Recupera.Location = new System.Drawing.Point(262, 50);
            this.B_Recupera.Name = "B_Recupera";
            this.B_Recupera.Size = new System.Drawing.Size(75, 23);
            this.B_Recupera.TabIndex = 10;
            this.B_Recupera.Text = "Recuperar";
            this.B_Recupera.UseVisualStyleBackColor = true;
            this.B_Recupera.Click += new System.EventHandler(this.B_Recupera_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nota";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.L_Qtd);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(461, 332);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quantidade de Colisões";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // L_Qtd
            // 
            this.L_Qtd.AutoSize = true;
            this.L_Qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Qtd.Location = new System.Drawing.Point(200, 138);
            this.L_Qtd.Name = "L_Qtd";
            this.L_Qtd.Size = new System.Drawing.Size(40, 42);
            this.L_Qtd.TabIndex = 0;
            this.L_Qtd.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 412);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Introdução ao Espalhamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Nome;
        private System.Windows.Forms.TextBox TB_Nota;
        private System.Windows.Forms.Button B_Insere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Posicao;
        private System.Windows.Forms.TextBox TB_Email_R;
        private System.Windows.Forms.TextBox TB_Nome_R;
        private System.Windows.Forms.TextBox TB_Nota_R;
        private System.Windows.Forms.Button B_Recupera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label L_Qtd;
    }
}

