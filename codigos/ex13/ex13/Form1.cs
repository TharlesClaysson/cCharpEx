using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex13
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
        LLS_Fila FilaMenores = new LLS_Fila();
        LLS_Fila FilaMaiores = new LLS_Fila();

        private void B_Insere_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            int v = Convert.ToInt32(TB_valor.Text);
            if (EstaCheia(fila) == false)
                Insere(fila, v);
            else
                MessageBox.Show("Fila cheia, não pode inserir mais valores.");
            TB_valor.Clear();
            TB_valor.Focus();
        }

        private void B_Divide_Click(object sender, EventArgs e)
        {
            int n, p;
            p = Convert.ToInt32(TB_metade.Text);
            while (EstaVazia(fila) == false)
            {
                n = Remove(fila);
                if (n <= p)
                    Insere(FilaMenores, n);
                else
                    Insere(FilaMaiores, n);
            }
        }

        private void B_Exibe_Click(object sender, EventArgs e)
        {
            int mn;
            while (EstaVazia(FilaMenores) == false)
            {
                mn = Remove(FilaMenores);
                listBox1.Items.Add(mn);
            }
            while (EstaVazia(FilaMaiores) == false)
            {
                mn = Remove(FilaMaiores);
                listBox2.Items.Add(mn);
            }
            TB_metade.Clear();
            TB_metade.Focus();
        }
    }
}
