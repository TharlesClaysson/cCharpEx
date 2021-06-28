using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio1_recurcividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void CrescIt(int nI, int nF)
        {
            while (nI <= nF)
            {
                LB_Resultados.Items.Add(nI);
                nI += 1;
            }
        }

        void CrescRec(int nI, int nF)
        {
            if (nI <= nF) 
            {
                LB_Resultados.Items.Add(nI);
                CrescRec(nI + 1, nF);
            }
        }

        private void B_Crescente_Click(object sender, EventArgs e)
        {
            int NumInicial, NumFinal;
            NumInicial = Convert.ToInt32(TB_NumInicial.Text);
            NumFinal = Convert.ToInt32(TB_NumFinal.Text);
            LB_Resultados.Items.Clear();
            //CrescIt(NumInicial, NumFinal);
            CrescRec(NumInicial, NumFinal);
        }

        void DecrescRec(int nI, int nF)
        {
            if (nF >= nI)
            {
                LB_Resultados.Items.Add(nF);
                DecrescRec(nI, nF - 1);
            }
        }

        void DecrescRec2(int nI, int nF)
        {
            if (nI <= nF)
            {
                DecrescRec2(nI + 1, nF);
                LB_Resultados.Items.Add(nI);
            }
        }

        private void B_Decrescente_Click(object sender, EventArgs e)
        {
            int NumInicial, NumFinal;
            NumInicial = Convert.ToInt32(TB_NumInicial.Text);
            NumFinal = Convert.ToInt32(TB_NumFinal.Text);
            LB_Resultados.Items.Clear();
            //DecrescRec(NumInicial, NumFinal);
            DecrescRec2(NumInicial, NumFinal);
        }

        int SomaIt(int nI, int nF)
        {
            int s = 0;
            while (nI <= nF)
            {
                s = s + nI;
                nI += 1;
            }
            return s;
        }
 
       int SomaRec(int nI, int nF)
        {
            if (nI < nF)
                return SomaRec(nI + 1, nF) + nI;
            else
                return nI;

        }
        private void B_Somatoria_Click(object sender, EventArgs e)
        {
            int NumInicial, NumFinal;
            NumInicial = Convert.ToInt32(TB_NumInicial.Text);
            NumFinal = Convert.ToInt32(TB_NumFinal.Text);
            LB_Resultados.Items.Clear();
            //int soma = SomaIt(NumInicial, NumFinal);
            int soma = SomaRec(NumInicial, NumFinal);
            LB_Resultados.Items.Add(soma);
        }
        void CrescImpar(int nI, int nF)
        {
            if (nI <= nF)
            {
                LB_Resultados.Items.Add(nI);
                CrescRec(nI + 1, nF);
            }
        }

        private void B_Impares_Click(object sender, EventArgs e)
        {
            int NumInicial, NumFinal;
            NumInicial = Convert.ToInt32(TB_NumInicial.Text);
            NumFinal = Convert.ToInt32(TB_NumFinal.Text);
            LB_Resultados.Items.Clear();
            CrescImpar(NumInicial, NumFinal);
        }

        int[] vetor = new int[20];
        int tl = 0;
        private void B_Insere_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(TB_Numero.Text);
            tl += 1;
            vetor[tl] = n;
            TB_Numero.Clear();
            TB_Numero.Focus();
        }

        int SomaVetorRec(int[] v, int nI, int nF)
        {
            if (nI < nF)
                return SomaVetorRec(v, nI + 1, nF) + v[nI];
            else
                return v[nI];
        }

        private void B_Soma_Click(object sender, EventArgs e)
        {
            int s = SomaVetorRec(vetor, 1, tl);
            //LB_Resultados.Items.Clear();
            LB_Resultados.Items.Add(s);
        }
    }
}
