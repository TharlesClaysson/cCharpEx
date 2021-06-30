using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Potencia(int nB, int nE, int nI)
        {
            if (nE >= 1)
                Respostas.Items.Clear();
                Respostas.Items.Add(nB);
                Potencia(nB * nI, nE - 1, nI);  
        }

        private void B_calcular_Click(object sender, EventArgs e)
        {
            int NumBase, NumExpoente, NumInicial;
            NumBase = Convert.ToInt32(TB_Base.Text);
            NumInicial = NumBase;
            NumExpoente = Convert.ToInt32(TB_Expoente.Text);
            Potencia(NumBase, NumExpoente, NumInicial);
        }

        int Cubos(int nB, int n)
        {
            if(n < 3)
                return Cubos(nB, n + 1) * nB;
            else
                return nB;

        }

        private void B_Cubos_Click(object sender, EventArgs e)
        {
            int Num, Base, Resp;
            Base = Convert.ToInt32(TB_Cubos.Text);
            Num = 1;
            Resp = Cubos(Base, Num);
            Respostas.Items.Clear();
            Respostas.Items.Add(Resp);
        }

        int MdcFunc(int a, int b, int c)
        {
            if (a % c > 0 || b % c > 0)
                return MdcFunc(a, b, c - 1);
            else
                return c;
        }
        private void B_Mdc_Click(object sender, EventArgs e)
        {
            int nA, nB, nC, resp;
            nA = Convert.ToInt32(TB_X.Text);
            nB = Convert.ToInt32(TB_Y.Text);
            if (nA >= nB)
                nC = nB;
            else
                nC = nA;
            resp = MdcFunc(nA, nB, nC);
            Respostas.Items.Clear();
            Respostas.Items.Add(resp);
        }

        int Seq(int Num)
        {
            if (Num <= 1)
                return Num;
            else
                return Seq(Num - 1) + Seq(Num - 2);
        }
        private void B_Fib_Click(object sender, EventArgs e)
        {
            Respostas.Items.Clear();
            int n, Fbnc;
            n = Convert.ToInt32(TB_Fibonacci.Text);
            Fbnc = Seq(n);
            Respostas.Items.Add(Fbnc);


        }

        int[] vetor = new int[100];
        int c = 0;
        void ConverteBinario(int[] v, int Num, int c)
        {
            if (Num / 2 > 0)
                ConverteBinario(v, Num / 2, c + 1);
                v[c] = Num % 2;
            Respostas.Items.Add(v[c]);
        }

        private void B_Bin_Click(object sender, EventArgs e)
        {
            Respostas.Items.Clear();
            int num = Convert.ToInt32(TB_Binario.Text);
            ConverteBinario(vetor ,num, c);
            TB_Binario.Clear();
        }
    }
}
