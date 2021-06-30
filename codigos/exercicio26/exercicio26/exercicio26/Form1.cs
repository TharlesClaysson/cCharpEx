using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int N = 5;
        class tp_registro
        {
            public int nota = 0;
            public string nome = "", email = "";
            public tp_registro prox = null;
        }
        int Hash(int chave)
        {
            return (chave % N);
        }
        void InsereLinear(tp_registro[] v, int nt, string nm, string em)
        {
            int pos = Hash(nt);
            while (v[pos].nota != 0)
            {
                pos++;
                pos = pos % N;
                L_Qtd.Text = Convert.ToString(Convert.ToInt32(L_Qtd.Text) + 1);
            }
            v[pos].nota = nt;
            v[pos].nome = nm;
            v[pos].email = em;
        }
        int RecuperaLinear(tp_registro[] v, int nt)
        {
            int pos = Hash(nt);
            while (v[pos].nota != nt)
            {
                pos++;
                pos = pos % N;
            }
            return pos;
        }
        tp_registro[] vetor = new tp_registro[N];

        private void B_Insere_Click(object sender, EventArgs e)
        {
            int nt = Convert.ToInt32(TB_Nota.Text);
            string nm = TB_Nome.Text, em = TB_Email.Text;
            InsereLinear(vetor, nt, nm, em);
        }
        private void B_Recupera_Click(object sender, EventArgs e)
        {
            int pos = RecuperaLinear(vetor, Convert.ToInt32(TB_Nota_R.Text));
            TB_Nome_R.Text = vetor[pos].nome;
            TB_Email_R.Text = vetor[pos].email;
            TB_Posicao.Text = Convert.ToString(pos);
        }
        // Evento Load do Form ocorre uma única vez quando o formulário é apresentado
        private void Form1_Load(object sender, EventArgs e)
        {
            // Esta inicialização não é necessária para o tratamento de colisão com lista encadeada
            for (int i = 0; i < N; i++)
                vetor[i] = new tp_registro();
        }
    }
}
