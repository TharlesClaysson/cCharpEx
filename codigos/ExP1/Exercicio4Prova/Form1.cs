using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int MAX = 50;

        class LLS_Fila
        {
            public int inicio = 0;
            public int fim = 0;
            public int[] vetor = new int[MAX];
        }

        bool EstaVazia(LLS_Fila f)
        {
            if (f.inicio == f.fim)
                return true;
            else
                return false;
        }
        bool EstaCheia(LLS_Fila f)
        {
            if (f.fim == MAX)
                return true;
            else
                return false;
        }


        void Insere(LLS_Fila f, char valor)
        {
            f.vetor[f.fim] = valor;
            f.fim = f.fim + 1;
        }

        int Remove(LLS_Fila f)
        {
            int valor = f.vetor[f.inicio];
            f.inicio = f.inicio + 1;
            return valor;
        }

        LLS_Fila fila = new LLS_Fila();

        private void B_Insere_Click(object sender, EventArgs e)
        {
            char n;
            n= Convert.ToChar(TB_Valor.Text);
            if (EstaCheia(fila) == false)
                Insere(fila, n);
            else
                MessageBox.Show("Fila cheia, não pode inserir mais valores.");
            TB_Valor.Clear();
            TB_Valor.Focus();
        }

        private void B_Exibe_Click(object sender, EventArgs e)
        {
            char n;
            while (EstaVazia(fila) == false)
            {
                n = Remove(fila);
                LB_Result.Items.Add(n);
            }
        }
    }
}
