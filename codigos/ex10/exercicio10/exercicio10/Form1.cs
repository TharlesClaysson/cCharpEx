using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int MAX = 50;
        class LLS_Pilha
        {
            public int topo = 0;
            public char[] vetor = new char[MAX];
        }
        bool EstaVazia(LLS_Pilha p)
        {
            if (p.topo == 0)
                return true;
            else
                return false;
        }
        bool EstaCheia(LLS_Pilha p)
        {
            if (p.topo == MAX)
                return true;
            else
                return false;
        }
        void Insere(LLS_Pilha p, char valor)
        {
            p.vetor[p.topo] = valor;
            p.topo = p.topo + 1;
        }
        char Remove(LLS_Pilha p)
        {
            p.topo = p.topo - 1;
            return (p.vetor[p.topo]);
        }

        LLS_Pilha pilha = new LLS_Pilha();

        private void B_Processa_Click(object sender, EventArgs e)
        {
            string frase, inverso;
            frase = TB_Frase.Text;
            inverso = " ";
            int i = 0, qtdLetras = frase.Length;
            while (i < qtdLetras)
            {
                if (frase[i] != ' ')
                    Insere(pilha, frase[i]);
                if (frase[i] == ' ' || i == qtdLetras-1)
                    while (EstaVazia(pilha) == false)
                    {
                        inverso += Remove(pilha);
                    }
                if (EstaVazia(pilha) == true)
                    inverso += ' ';
                i += 1;
            }
            TB_PalavrasInv.Text = inverso;
        }
    }
}
