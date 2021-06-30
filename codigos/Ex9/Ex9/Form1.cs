using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex9
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
            p.vetor[p.topo++] = valor;
        }

        private void B_Processar_Click(object sender, EventArgs e)
        {
            string Num = TB_Num.Text; 

        }
    }
}
