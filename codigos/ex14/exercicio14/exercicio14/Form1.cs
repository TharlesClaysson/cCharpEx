using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int MAX = 20;
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
        void Insere(LLS_Fila f, int valor)
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
            int n;
            n = Convert.ToInt32(TB_Numero.Text);
            if (EstaCheia(fila) == false)
                Insere(fila, n);
            else
                MessageBox.Show("Fila cheia, não pode inserir mais valores.");
            TB_Numero.Clear();
            TB_Numero.Focus();
        }

        private void B_Processa_Click(object sender, EventArgs e)
        {
            int n, maior, menor, soma, qtd;
            soma = qtd = 0;
            n = Remove(fila);
            maior = menor = n;
            soma += n;
            qtd++;
            while (EstaVazia(fila) == false)
            {
                n = Remove(fila);
                if (n > maior)
                   maior = n;
                if (n < menor)
                   menor = n;
                
                soma += n;
                qtd++;
            }
            LB_Resultados.Items.Add("Maior: " + maior);
            LB_Resultados.Items.Add("Menor: " + menor);
            LB_Resultados.Items.Add("Média: " + soma / qtd);
        }
    }
}
