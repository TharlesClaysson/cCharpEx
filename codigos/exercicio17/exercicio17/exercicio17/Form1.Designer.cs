
namespace exercicio17
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
            this.CB_I = new System.Windows.Forms.ComboBox();
            this.TB_Idade_I = new System.Windows.Forms.TextBox();
            this.TB_Nome_I = new System.Windows.Forms.TextBox();
            this.B_Inclui = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.B_Procurar_A = new System.Windows.Forms.Button();
            this.TB_NomeProc_A = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_A = new System.Windows.Forms.ComboBox();
            this.TB_Idade_A = new System.Windows.Forms.TextBox();
            this.TB_Nome_A = new System.Windows.Forms.TextBox();
            this.B_Altera = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.B_Procurar_E = new System.Windows.Forms.Button();
            this.TB_Procurar_E = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_E = new System.Windows.Forms.ComboBox();
            this.TB_Idade_E = new System.Windows.Forms.TextBox();
            this.TB_Nome_E = new System.Windows.Forms.TextBox();
            this.B_Exclui = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LB_Relatorio = new System.Windows.Forms.ListBox();
            this.B_Exibe = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 342);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CB_I);
            this.tabPage1.Controls.Add(this.TB_Idade_I);
            this.tabPage1.Controls.Add(this.TB_Nome_I);
            this.tabPage1.Controls.Add(this.B_Inclui);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Incluir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CB_I
            // 
            this.CB_I.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_I.FormattingEnabled = true;
            this.CB_I.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.CB_I.Location = new System.Drawing.Point(98, 152);
            this.CB_I.Name = "CB_I";
            this.CB_I.Size = new System.Drawing.Size(121, 21);
            this.CB_I.TabIndex = 6;
            // 
            // TB_Idade_I
            // 
            this.TB_Idade_I.Location = new System.Drawing.Point(97, 98);
            this.TB_Idade_I.Name = "TB_Idade_I";
            this.TB_Idade_I.Size = new System.Drawing.Size(67, 20);
            this.TB_Idade_I.TabIndex = 5;
            // 
            // TB_Nome_I
            // 
            this.TB_Nome_I.Location = new System.Drawing.Point(97, 50);
            this.TB_Nome_I.Name = "TB_Nome_I";
            this.TB_Nome_I.Size = new System.Drawing.Size(205, 20);
            this.TB_Nome_I.TabIndex = 4;
            // 
            // B_Inclui
            // 
            this.B_Inclui.Location = new System.Drawing.Point(161, 220);
            this.B_Inclui.Name = "B_Inclui";
            this.B_Inclui.Size = new System.Drawing.Size(75, 23);
            this.B_Inclui.TabIndex = 3;
            this.B_Inclui.Text = "Inclui";
            this.B_Inclui.UseVisualStyleBackColor = true;
            this.B_Inclui.Click += new System.EventHandler(this.B_Inclui_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gênero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.B_Procurar_A);
            this.tabPage2.Controls.Add(this.TB_NomeProc_A);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.CB_A);
            this.tabPage2.Controls.Add(this.TB_Idade_A);
            this.tabPage2.Controls.Add(this.TB_Nome_A);
            this.tabPage2.Controls.Add(this.B_Altera);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alterar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // B_Procurar_A
            // 
            this.B_Procurar_A.Location = new System.Drawing.Point(154, 69);
            this.B_Procurar_A.Name = "B_Procurar_A";
            this.B_Procurar_A.Size = new System.Drawing.Size(75, 23);
            this.B_Procurar_A.TabIndex = 16;
            this.B_Procurar_A.Text = "Procurar";
            this.B_Procurar_A.UseVisualStyleBackColor = true;
            this.B_Procurar_A.Click += new System.EventHandler(this.B_Procurar_A_Click);
            // 
            // TB_NomeProc_A
            // 
            this.TB_NomeProc_A.Location = new System.Drawing.Point(130, 31);
            this.TB_NomeProc_A.Name = "TB_NomeProc_A";
            this.TB_NomeProc_A.Size = new System.Drawing.Size(240, 20);
            this.TB_NomeProc_A.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nome procurado";
            // 
            // CB_A
            // 
            this.CB_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_A.FormattingEnabled = true;
            this.CB_A.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.CB_A.Location = new System.Drawing.Point(139, 214);
            this.CB_A.Name = "CB_A";
            this.CB_A.Size = new System.Drawing.Size(121, 21);
            this.CB_A.TabIndex = 13;
            // 
            // TB_Idade_A
            // 
            this.TB_Idade_A.Location = new System.Drawing.Point(139, 174);
            this.TB_Idade_A.Name = "TB_Idade_A";
            this.TB_Idade_A.Size = new System.Drawing.Size(67, 20);
            this.TB_Idade_A.TabIndex = 12;
            // 
            // TB_Nome_A
            // 
            this.TB_Nome_A.Location = new System.Drawing.Point(139, 135);
            this.TB_Nome_A.Name = "TB_Nome_A";
            this.TB_Nome_A.Size = new System.Drawing.Size(205, 20);
            this.TB_Nome_A.TabIndex = 11;
            // 
            // B_Altera
            // 
            this.B_Altera.Location = new System.Drawing.Point(130, 267);
            this.B_Altera.Name = "B_Altera";
            this.B_Altera.Size = new System.Drawing.Size(75, 23);
            this.B_Altera.TabIndex = 10;
            this.B_Altera.Text = "Altera";
            this.B_Altera.UseVisualStyleBackColor = true;
            this.B_Altera.Click += new System.EventHandler(this.B_Altera_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gênero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Idade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nome";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.B_Procurar_E);
            this.tabPage3.Controls.Add(this.TB_Procurar_E);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.CB_E);
            this.tabPage3.Controls.Add(this.TB_Idade_E);
            this.tabPage3.Controls.Add(this.TB_Nome_E);
            this.tabPage3.Controls.Add(this.B_Exclui);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(426, 316);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Excluir";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // B_Procurar_E
            // 
            this.B_Procurar_E.Location = new System.Drawing.Point(166, 67);
            this.B_Procurar_E.Name = "B_Procurar_E";
            this.B_Procurar_E.Size = new System.Drawing.Size(75, 23);
            this.B_Procurar_E.TabIndex = 26;
            this.B_Procurar_E.Text = "Procurar";
            this.B_Procurar_E.UseVisualStyleBackColor = true;
            this.B_Procurar_E.Click += new System.EventHandler(this.B_Procurar_E_Click);
            // 
            // TB_Procurar_E
            // 
            this.TB_Procurar_E.Location = new System.Drawing.Point(142, 29);
            this.TB_Procurar_E.Name = "TB_Procurar_E";
            this.TB_Procurar_E.Size = new System.Drawing.Size(240, 20);
            this.TB_Procurar_E.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nome procurado";
            // 
            // CB_E
            // 
            this.CB_E.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_E.FormattingEnabled = true;
            this.CB_E.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.CB_E.Location = new System.Drawing.Point(151, 212);
            this.CB_E.Name = "CB_E";
            this.CB_E.Size = new System.Drawing.Size(121, 21);
            this.CB_E.TabIndex = 23;
            // 
            // TB_Idade_E
            // 
            this.TB_Idade_E.Location = new System.Drawing.Point(151, 172);
            this.TB_Idade_E.Name = "TB_Idade_E";
            this.TB_Idade_E.Size = new System.Drawing.Size(67, 20);
            this.TB_Idade_E.TabIndex = 22;
            // 
            // TB_Nome_E
            // 
            this.TB_Nome_E.Location = new System.Drawing.Point(151, 133);
            this.TB_Nome_E.Name = "TB_Nome_E";
            this.TB_Nome_E.Size = new System.Drawing.Size(205, 20);
            this.TB_Nome_E.TabIndex = 21;
            // 
            // B_Exclui
            // 
            this.B_Exclui.Location = new System.Drawing.Point(142, 265);
            this.B_Exclui.Name = "B_Exclui";
            this.B_Exclui.Size = new System.Drawing.Size(75, 23);
            this.B_Exclui.TabIndex = 20;
            this.B_Exclui.Text = "Exclui";
            this.B_Exclui.UseVisualStyleBackColor = true;
            this.B_Exclui.Click += new System.EventHandler(this.B_Exclui_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Gênero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Idade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nome";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.LB_Relatorio);
            this.tabPage4.Controls.Add(this.B_Exibe);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(426, 316);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Exibir";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LB_Relatorio
            // 
            this.LB_Relatorio.FormattingEnabled = true;
            this.LB_Relatorio.Location = new System.Drawing.Point(135, 96);
            this.LB_Relatorio.Name = "LB_Relatorio";
            this.LB_Relatorio.Size = new System.Drawing.Size(137, 186);
            this.LB_Relatorio.TabIndex = 1;
            // 
            // B_Exibe
            // 
            this.B_Exibe.Location = new System.Drawing.Point(155, 41);
            this.B_Exibe.Name = "B_Exibe";
            this.B_Exibe.Size = new System.Drawing.Size(75, 23);
            this.B_Exibe.TabIndex = 0;
            this.B_Exibe.Text = "Exibe todos";
            this.B_Exibe.UseVisualStyleBackColor = true;
            this.B_Exibe.Click += new System.EventHandler(this.B_Exibe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 367);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Gerenciar Pessoas - Lista Linear Encadeada";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox CB_I;
        private System.Windows.Forms.TextBox TB_Idade_I;
        private System.Windows.Forms.TextBox TB_Nome_I;
        private System.Windows.Forms.Button B_Inclui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button B_Procurar_A;
        private System.Windows.Forms.TextBox TB_NomeProc_A;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_A;
        private System.Windows.Forms.TextBox TB_Idade_A;
        private System.Windows.Forms.TextBox TB_Nome_A;
        private System.Windows.Forms.Button B_Altera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button B_Procurar_E;
        private System.Windows.Forms.TextBox TB_Procurar_E;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_E;
        private System.Windows.Forms.TextBox TB_Idade_E;
        private System.Windows.Forms.TextBox TB_Nome_E;
        private System.Windows.Forms.Button B_Exclui;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox LB_Relatorio;
        private System.Windows.Forms.Button B_Exibe;
    }
}

