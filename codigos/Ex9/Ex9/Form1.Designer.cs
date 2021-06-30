
namespace Ex9
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
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Num = new System.Windows.Forms.TextBox();
            this.TB_Operacoes = new System.Windows.Forms.TextBox();
            this.TB_Resultado = new System.Windows.Forms.TextBox();
            this.B_Processar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(66, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "n°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(66, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operações";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(66, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Num
            // 
            this.TB_Num.BackColor = System.Drawing.SystemColors.Window;
            this.TB_Num.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Num.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TB_Num.Location = new System.Drawing.Point(201, 38);
            this.TB_Num.Name = "TB_Num";
            this.TB_Num.Size = new System.Drawing.Size(47, 26);
            this.TB_Num.TabIndex = 3;
            // 
            // TB_Operacoes
            // 
            this.TB_Operacoes.BackColor = System.Drawing.SystemColors.Window;
            this.TB_Operacoes.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Operacoes.Location = new System.Drawing.Point(201, 106);
            this.TB_Operacoes.Name = "TB_Operacoes";
            this.TB_Operacoes.Size = new System.Drawing.Size(100, 26);
            this.TB_Operacoes.TabIndex = 4;
            // 
            // TB_Resultado
            // 
            this.TB_Resultado.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Resultado.Location = new System.Drawing.Point(201, 264);
            this.TB_Resultado.Name = "TB_Resultado";
            this.TB_Resultado.Size = new System.Drawing.Size(100, 26);
            this.TB_Resultado.TabIndex = 5;
            // 
            // B_Processar
            // 
            this.B_Processar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.B_Processar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Processar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B_Processar.FlatAppearance.BorderSize = 10;
            this.B_Processar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.B_Processar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Processar.Location = new System.Drawing.Point(201, 184);
            this.B_Processar.Name = "B_Processar";
            this.B_Processar.Size = new System.Drawing.Size(100, 36);
            this.B_Processar.TabIndex = 6;
            this.B_Processar.Text = "Processar";
            this.B_Processar.UseVisualStyleBackColor = false;
            this.B_Processar.Click += new System.EventHandler(this.B_Processar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ex9.Properties.Resources.fundoengrenagem;
            this.ClientSize = new System.Drawing.Size(365, 318);
            this.Controls.Add(this.B_Processar);
            this.Controls.Add(this.TB_Resultado);
            this.Controls.Add(this.TB_Operacoes);
            this.Controls.Add(this.TB_Num);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Num;
        private System.Windows.Forms.TextBox TB_Operacoes;
        private System.Windows.Forms.TextBox TB_Resultado;
        private System.Windows.Forms.Button B_Processar;
    }
}

