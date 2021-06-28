
namespace ex27
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Relatorio_ST = new System.Windows.Forms.ListBox();
            this.BE_Sem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBS_Sem = new System.Windows.Forms.ComboBox();
            this.TBN_Sem = new System.Windows.Forms.TextBox();
            this.TBI_Sem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BG_Sem = new System.Windows.Forms.Button();
            this.BP_Sem = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Relatorio_Linear = new System.Windows.Forms.ListBox();
            this.BE_Linear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CBS_Linear = new System.Windows.Forms.ComboBox();
            this.TBN_Linear = new System.Windows.Forms.TextBox();
            this.TBI_Linear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BG_Linear = new System.Windows.Forms.Button();
            this.BP_Linear = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Relatorio_Enc = new System.Windows.Forms.ListBox();
            this.BE_Enc = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CBS_Enc = new System.Windows.Forms.ComboBox();
            this.TBN_Enc = new System.Windows.Forms.TextBox();
            this.TBI_Enc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BG_Enc = new System.Windows.Forms.Button();
            this.BP_Enc = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(40, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(607, 395);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.Form2_Load);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(599, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sem tratamento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Relatorio_ST);
            this.groupBox2.Controls.Add(this.BE_Sem);
            this.groupBox2.Location = new System.Drawing.Point(349, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 318);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relatório";
            // 
            // Relatorio_ST
            // 
            this.Relatorio_ST.FormattingEnabled = true;
            this.Relatorio_ST.Location = new System.Drawing.Point(40, 65);
            this.Relatorio_ST.Name = "Relatorio_ST";
            this.Relatorio_ST.Size = new System.Drawing.Size(136, 225);
            this.Relatorio_ST.TabIndex = 2;
            // 
            // BE_Sem
            // 
            this.BE_Sem.Location = new System.Drawing.Point(65, 36);
            this.BE_Sem.Name = "BE_Sem";
            this.BE_Sem.Size = new System.Drawing.Size(75, 23);
            this.BE_Sem.TabIndex = 1;
            this.BE_Sem.Text = "Exibir";
            this.BE_Sem.UseVisualStyleBackColor = true;
            this.BE_Sem.Click += new System.EventHandler(this.BE_Sem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBS_Sem);
            this.groupBox1.Controls.Add(this.TBN_Sem);
            this.groupBox1.Controls.Add(this.TBI_Sem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BG_Sem);
            this.groupBox1.Controls.Add(this.BP_Sem);
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir/Pesquisar/Alterar";
            // 
            // CBS_Sem
            // 
            this.CBS_Sem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBS_Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBS_Sem.FormattingEnabled = true;
            this.CBS_Sem.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Não opinar"});
            this.CBS_Sem.Location = new System.Drawing.Point(96, 177);
            this.CBS_Sem.Name = "CBS_Sem";
            this.CBS_Sem.Size = new System.Drawing.Size(121, 24);
            this.CBS_Sem.TabIndex = 8;
            // 
            // TBN_Sem
            // 
            this.TBN_Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBN_Sem.Location = new System.Drawing.Point(96, 124);
            this.TBN_Sem.Name = "TBN_Sem";
            this.TBN_Sem.Size = new System.Drawing.Size(168, 22);
            this.TBN_Sem.TabIndex = 7;
            // 
            // TBI_Sem
            // 
            this.TBI_Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBI_Sem.Location = new System.Drawing.Point(96, 59);
            this.TBI_Sem.Name = "TBI_Sem";
            this.TBI_Sem.Size = new System.Drawing.Size(81, 22);
            this.TBI_Sem.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Idade";
            // 
            // BG_Sem
            // 
            this.BG_Sem.Location = new System.Drawing.Point(119, 235);
            this.BG_Sem.Name = "BG_Sem";
            this.BG_Sem.Size = new System.Drawing.Size(98, 23);
            this.BG_Sem.TabIndex = 2;
            this.BG_Sem.Text = "Gravar ou Excluir";
            this.BG_Sem.UseVisualStyleBackColor = true;
            this.BG_Sem.Click += new System.EventHandler(this.BG_Sem_Click);
            // 
            // BP_Sem
            // 
            this.BP_Sem.Location = new System.Drawing.Point(189, 58);
            this.BP_Sem.Name = "BP_Sem";
            this.BP_Sem.Size = new System.Drawing.Size(75, 23);
            this.BP_Sem.TabIndex = 1;
            this.BP_Sem.Text = "Procurar";
            this.BP_Sem.UseVisualStyleBackColor = true;
            this.BP_Sem.Click += new System.EventHandler(this.BP_Sem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(599, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Com tratamento linear";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Relatorio_Linear);
            this.groupBox3.Controls.Add(this.BE_Linear);
            this.groupBox3.Location = new System.Drawing.Point(360, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 318);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Relatório";
            // 
            // Relatorio_Linear
            // 
            this.Relatorio_Linear.FormattingEnabled = true;
            this.Relatorio_Linear.Location = new System.Drawing.Point(40, 65);
            this.Relatorio_Linear.Name = "Relatorio_Linear";
            this.Relatorio_Linear.Size = new System.Drawing.Size(136, 225);
            this.Relatorio_Linear.TabIndex = 2;
            // 
            // BE_Linear
            // 
            this.BE_Linear.Location = new System.Drawing.Point(65, 36);
            this.BE_Linear.Name = "BE_Linear";
            this.BE_Linear.Size = new System.Drawing.Size(75, 23);
            this.BE_Linear.TabIndex = 1;
            this.BE_Linear.Text = "Exibir";
            this.BE_Linear.UseVisualStyleBackColor = true;
            this.BE_Linear.Click += new System.EventHandler(this.BE_Linear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CBS_Linear);
            this.groupBox4.Controls.Add(this.TBN_Linear);
            this.groupBox4.Controls.Add(this.TBI_Linear);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.BG_Linear);
            this.groupBox4.Controls.Add(this.BP_Linear);
            this.groupBox4.Location = new System.Drawing.Point(32, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(301, 318);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inserir/Pesquisar/Alterar";
            // 
            // CBS_Linear
            // 
            this.CBS_Linear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBS_Linear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBS_Linear.FormattingEnabled = true;
            this.CBS_Linear.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Não opinar"});
            this.CBS_Linear.Location = new System.Drawing.Point(96, 177);
            this.CBS_Linear.Name = "CBS_Linear";
            this.CBS_Linear.Size = new System.Drawing.Size(121, 24);
            this.CBS_Linear.TabIndex = 8;
            // 
            // TBN_Linear
            // 
            this.TBN_Linear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBN_Linear.Location = new System.Drawing.Point(96, 124);
            this.TBN_Linear.Name = "TBN_Linear";
            this.TBN_Linear.Size = new System.Drawing.Size(168, 22);
            this.TBN_Linear.TabIndex = 7;
            // 
            // TBI_Linear
            // 
            this.TBI_Linear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBI_Linear.Location = new System.Drawing.Point(96, 59);
            this.TBI_Linear.Name = "TBI_Linear";
            this.TBI_Linear.Size = new System.Drawing.Size(81, 22);
            this.TBI_Linear.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Idade";
            // 
            // BG_Linear
            // 
            this.BG_Linear.Location = new System.Drawing.Point(119, 235);
            this.BG_Linear.Name = "BG_Linear";
            this.BG_Linear.Size = new System.Drawing.Size(98, 23);
            this.BG_Linear.TabIndex = 2;
            this.BG_Linear.Text = "Gravar ou Excluir";
            this.BG_Linear.UseVisualStyleBackColor = true;
            this.BG_Linear.Click += new System.EventHandler(this.BG_Linear_Click);
            // 
            // BP_Linear
            // 
            this.BP_Linear.Location = new System.Drawing.Point(189, 58);
            this.BP_Linear.Name = "BP_Linear";
            this.BP_Linear.Size = new System.Drawing.Size(75, 23);
            this.BP_Linear.TabIndex = 1;
            this.BP_Linear.Text = "Procurar";
            this.BP_Linear.UseVisualStyleBackColor = true;
            this.BP_Linear.Click += new System.EventHandler(this.BP_Linear_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(599, 369);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Com tratamento de lista encadeada";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Relatorio_Enc);
            this.groupBox5.Controls.Add(this.BE_Enc);
            this.groupBox5.Location = new System.Drawing.Point(360, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 318);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Relatório";
            // 
            // Relatorio_Enc
            // 
            this.Relatorio_Enc.FormattingEnabled = true;
            this.Relatorio_Enc.Location = new System.Drawing.Point(40, 65);
            this.Relatorio_Enc.Name = "Relatorio_Enc";
            this.Relatorio_Enc.Size = new System.Drawing.Size(136, 225);
            this.Relatorio_Enc.TabIndex = 2;
            // 
            // BE_Enc
            // 
            this.BE_Enc.Location = new System.Drawing.Point(65, 36);
            this.BE_Enc.Name = "BE_Enc";
            this.BE_Enc.Size = new System.Drawing.Size(75, 23);
            this.BE_Enc.TabIndex = 1;
            this.BE_Enc.Text = "Exibir";
            this.BE_Enc.UseVisualStyleBackColor = true;
            this.BE_Enc.Click += new System.EventHandler(this.BE_Enc_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CBS_Enc);
            this.groupBox6.Controls.Add(this.TBN_Enc);
            this.groupBox6.Controls.Add(this.TBI_Enc);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.BG_Enc);
            this.groupBox6.Controls.Add(this.BP_Enc);
            this.groupBox6.Location = new System.Drawing.Point(32, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(301, 318);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Inserir/Pesquisar/Alterar";
            // 
            // CBS_Enc
            // 
            this.CBS_Enc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBS_Enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBS_Enc.FormattingEnabled = true;
            this.CBS_Enc.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Não opinar"});
            this.CBS_Enc.Location = new System.Drawing.Point(96, 177);
            this.CBS_Enc.Name = "CBS_Enc";
            this.CBS_Enc.Size = new System.Drawing.Size(121, 24);
            this.CBS_Enc.TabIndex = 8;
            // 
            // TBN_Enc
            // 
            this.TBN_Enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBN_Enc.Location = new System.Drawing.Point(96, 124);
            this.TBN_Enc.Name = "TBN_Enc";
            this.TBN_Enc.Size = new System.Drawing.Size(168, 22);
            this.TBN_Enc.TabIndex = 7;
            // 
            // TBI_Enc
            // 
            this.TBI_Enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBI_Enc.Location = new System.Drawing.Point(96, 59);
            this.TBI_Enc.Name = "TBI_Enc";
            this.TBI_Enc.Size = new System.Drawing.Size(81, 22);
            this.TBI_Enc.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Idade";
            // 
            // BG_Enc
            // 
            this.BG_Enc.Location = new System.Drawing.Point(119, 235);
            this.BG_Enc.Name = "BG_Enc";
            this.BG_Enc.Size = new System.Drawing.Size(98, 23);
            this.BG_Enc.TabIndex = 2;
            this.BG_Enc.Text = "Gravar ou Excluir";
            this.BG_Enc.UseVisualStyleBackColor = true;
            this.BG_Enc.Click += new System.EventHandler(this.BG_Enc_Click);
            // 
            // BP_Enc
            // 
            this.BP_Enc.Location = new System.Drawing.Point(189, 58);
            this.BP_Enc.Name = "BP_Enc";
            this.BP_Enc.Size = new System.Drawing.Size(75, 23);
            this.BP_Enc.TabIndex = 1;
            this.BP_Enc.Text = "Procurar";
            this.BP_Enc.UseVisualStyleBackColor = true;
            this.BP_Enc.Click += new System.EventHandler(this.BP_Enc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Espelhamento  Avançado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox Relatorio_ST;
        private System.Windows.Forms.Button BE_Sem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBS_Sem;
        private System.Windows.Forms.TextBox TBN_Sem;
        private System.Windows.Forms.TextBox TBI_Sem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BG_Sem;
        private System.Windows.Forms.Button BP_Sem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox Relatorio_Linear;
        private System.Windows.Forms.Button BE_Linear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox CBS_Linear;
        private System.Windows.Forms.TextBox TBN_Linear;
        private System.Windows.Forms.TextBox TBI_Linear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BG_Linear;
        private System.Windows.Forms.Button BP_Linear;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox Relatorio_Enc;
        private System.Windows.Forms.Button BE_Enc;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox CBS_Enc;
        private System.Windows.Forms.TextBox TBN_Enc;
        private System.Windows.Forms.TextBox TBI_Enc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BG_Enc;
        private System.Windows.Forms.Button BP_Enc;
    }
}

