using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class tp_no
        {
            public int idade;
            public string nome, sexo;
            public tp_no prox;
        }

        int Cont = -1;
        const int N = 5;
        tp_no[] vetorSemTratamento = new tp_no[N], vetorLinear = new tp_no[N];
        tp_no[] vetorEncadeado = new tp_no[N];
        tp_no atual = null, anterior = null;

        int Hash(int chave)
        {
            return (chave % N);
        }

        void InsereSemTratamento(tp_no[] v, int i, string n, string s)
        {
            int pos = Hash(i);
            v[pos].idade = i;
            v[pos].nome = n;
            v[pos].sexo = s;
        }

        int BuscaSemTratamento(int i)
        {
            int pos = Hash(i);
            if (vetorSemTratamento[pos].idade == i)
                return pos;
            else
                return -1;
        }

        void InsereLinear(tp_no[] v, int i, string n, string s)
        {
            int c = 0;
            int pos = Hash(i);
            if (v[pos].idade == i && v[pos].nome == n)
            {
                MessageBox.Show("Valor já existente, será alterado pelo atual!");
                v[pos].idade = i;
                v[pos].nome = n;
                v[pos].sexo = s;
            }
            else
            {
                while (v[pos].idade != 0 && c < N)
                {
                    pos++;
                    pos = pos % N;
                    c++;
                }
                if (c < N)
                {
                    v[pos].idade = i;
                    v[pos].nome = n;
                    v[pos].sexo = s;
                }
                else
                    MessageBox.Show("Não há mais espaço no vetor, Exclusão necessária!");
            }
        }

        int BuscaLinear(tp_no[] v, int i)
        {
            int c = 0;
            int pos = Hash(i);
            while (v[pos].idade != i && c < N)
            {
                pos++;
                pos = pos % N;
                c++;
            }
            if (c < N)
                return pos;
            else
                return -1;
        }
        bool verd;
        void InsereEncadeado(tp_no[] v,ref tp_no a, ref tp_no ant, int i, string n, string s)
        {
            verd = false;
            tp_no no = new tp_no();
            no.idade = i;
            no.nome = n;
            no.sexo = s;
            int pos = Hash(no.idade);
            ant = null;
            a = v[pos];
            if (v[pos] != null)
            {
                while (a.idade != i && a.prox != null)
                {
                    if (a.idade != i)
                        verd = false;
                    else
                        verd = true;
                    ant = a;
                    a = a.prox;
                }
                if (verd == false)
                    no.prox = v[pos];
                else
                {
                    MessageBox.Show("O cadastro com esses dados, ele será atualizado com os dados recentes");
                    a.idade = i;
                    a.nome = n;
                    a.sexo = s;
                }
            }
            v[pos] = no;
        }

        void BuscaEncadeado(tp_no[] v, int i, ref tp_no a, ref tp_no ant)
        {
            verd = false;
            int pos = Hash(i);
            ant = null;
            a = v[pos];
            while (a.idade != i && a.prox != null)
            {
                if (a.idade != i)
                    verd = false;
                else
                    verd = true;
                ant = a;
                a = a.prox;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < N; i++)
            {
                vetorSemTratamento[i] = new tp_no();
                vetorLinear[i] = new tp_no();
                vetorEncadeado[i] = new tp_no();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cont = -1;
        }

        private void BG_Sem_Click(object sender, EventArgs e)
        {
            if (TBI_Sem.Text != "")
            {
                int i = Convert.ToInt32(TBI_Sem.Text);
                if (i % N == Cont)
                {
                    MessageBox.Show("Dados alterados com sucesso!");
                    InsereSemTratamento(vetorSemTratamento, i, TBN_Sem.Text, CBS_Sem.Text);
                    Cont = -1;
                }
                else
                    InsereSemTratamento(vetorSemTratamento, i, TBN_Sem.Text, CBS_Sem.Text);
            }
            else
            {
                if (Cont != -1)
                {
                    MessageBox.Show("Dados excluidos!");
                    vetorSemTratamento[Cont].idade = 0;
                    vetorSemTratamento[Cont].nome = "";
                    vetorSemTratamento[Cont].sexo = "";
                    Cont = -1;
                }
                else
                    MessageBox.Show("Você precisa completar todos os campos!");
            }
            Relatorio_ST.Items.Clear();
            TBI_Sem.Clear();
            TBN_Sem.Clear();
            TBI_Sem.Focus();
        }
        
        private void BP_Sem_Click(object sender, EventArgs e)
        {
            Relatorio_ST.Items.Clear();
            if (TBI_Sem.Text != "")
            {
                int pos = BuscaSemTratamento(Convert.ToInt32(TBI_Sem.Text));
                if (pos != -1)
                {
                    TBN_Sem.Text = vetorSemTratamento[pos].nome;
                    CBS_Sem.Text = vetorSemTratamento[pos].sexo;
                    Cont = pos;
                    MessageBox.Show("Se você deixar em branco o campo da idade e clicar em: Gravar ou Excluir, os dados serão excluidos");
                }
                else
                {
                    MessageBox.Show("Valor não não encontrado!");
                    TBI_Sem.Clear();
                    TBI_Sem.Clear();
                    TBI_Sem.Focus();
                }
            }
            else
            {
                MessageBox.Show("Você precisa inserir uma idade para busca!");
                TBN_Sem.Clear();
                TBI_Sem.Focus();
            }
        }

        private void BE_Sem_Click(object sender, EventArgs e)
        {
            int c = 1;
            Relatorio_ST.Items.Clear();
            for (int i  = 0; i < N; i++)
            {
                if (vetorSemTratamento[i].idade != 0)
                {
                    Relatorio_ST.Items.Add("Registro: " + c++);
                    Relatorio_ST.Items.Add("Idade: " + vetorSemTratamento[i].idade);
                    Relatorio_ST.Items.Add("Nome: " + vetorSemTratamento[i].nome);
                    Relatorio_ST.Items.Add("Gênero: " + vetorSemTratamento[i].sexo);
                    Relatorio_ST.Items.Add(" - - - - - - - ");
                }
            }
        }

        private void BG_Linear_Click(object sender, EventArgs e)
        {
            if (TBI_Linear.Text != "")
            {
                int i = Convert.ToInt32(TBI_Linear.Text);
                if (i % N == Cont)
                {
                    MessageBox.Show("Dados alterados com sucesso!");
                    vetorLinear[Cont].idade = i;
                    vetorLinear[Cont].nome = TBN_Linear.Text;
                    vetorLinear[Cont].sexo = CBS_Linear.Text;
                    Cont = -1;
                }
                else
                    InsereLinear(vetorLinear, i, TBN_Linear.Text, CBS_Linear.Text);
            }
            else
            {
                if (Cont != -1)
                {
                    MessageBox.Show("Dados excluidos!");
                    vetorLinear[Cont].idade = 0;
                    vetorLinear[Cont].nome = "";
                    vetorLinear[Cont].sexo = "";
                    Cont = -1;
                }
                else
                    MessageBox.Show("Você precisa completar todos os campos!");
            }
            Relatorio_Linear.Items.Clear();
            TBI_Linear.Clear();
            TBN_Linear.Clear();
            TBI_Linear.Focus();
        }

        private void BP_Linear_Click(object sender, EventArgs e)
        {
            Relatorio_Linear.Items.Clear();
            if (TBI_Linear.Text != "")
            {
                int pos = BuscaLinear(vetorLinear, Convert.ToInt32(TBI_Linear.Text));
                if (pos != -1)
                {
                    TBN_Linear.Text = vetorLinear[pos].nome;
                    CBS_Linear.Text = vetorLinear[pos].sexo;
                    Cont = pos;
                    MessageBox.Show("Se você deixar em branco o campo da idade e clicar em: Gravar ou Excluir, os dados serão excluidos");
                }
                else
                {
                    MessageBox.Show("Valor não não encontrado!");
                    TBI_Linear.Clear();
                    TBI_Linear.Clear();
                    TBI_Linear.Focus();
                }
            }
            else
            {
                MessageBox.Show("Você precisa inserir uma idade para busca!");
                TBN_Linear.Clear();
                TBI_Linear.Focus();
            }
        }


        private void BE_Linear_Click(object sender, EventArgs e)
        {
            int c = 1;
            for (int i = 0; i < N; i++)
            {
                if (vetorLinear[i].idade != 0)
                {
                    Relatorio_Linear.Items.Add("Registro: " + c++);
                    Relatorio_Linear.Items.Add("Idade: " + vetorLinear[i].idade); ;
                    Relatorio_Linear.Items.Add("Nome: " + vetorLinear[i].nome);
                    Relatorio_Linear.Items.Add("Gênero: " + vetorLinear[i].sexo);
                    Relatorio_Linear.Items.Add(" - - - - - - - ");
                }
            }
        }

        private void BG_Enc_Click(object sender, EventArgs e)
        {
            if (TBI_Enc.Text != "")
            {
                InsereEncadeado(vetorEncadeado, ref atual, ref anterior, Convert.ToInt32(TBI_Enc.Text), TBN_Enc.Text, CBS_Enc.Text);
            }
            else
                MessageBox.Show("Você precisa inserir todos os campos!");
            TBI_Enc.Clear();
            TBI_Enc.Focus();
            TBN_Enc.Clear();
            Relatorio_Enc.Items.Clear();
        }

        private void BP_Enc_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(TBI_Enc.Text);
            BuscaEncadeado(vetorEncadeado, i, ref atual, ref anterior);
            if (atual.idade == i)
            {
                TBN_Enc.Text = atual.nome;
                CBS_Enc.Text = atual.sexo;
                verd = true;
            }
            else
            {
                MessageBox.Show("Não encontrado");
                TBI_Enc.Clear();
                TBN_Enc.Clear();
                TBI_Enc.Focus();
                verd = false;
            }
            Relatorio_Enc.Items.Clear();
        }

        private void BE_Enc_Click(object sender, EventArgs e)
        {
            Relatorio_Enc.Items.Clear();
            int c = 1;
            for (int i = 0; i < N; i++)
            {
                if (vetorEncadeado[i].idade != 0)
                {
                    atual = vetorEncadeado[i];
                    while (atual.prox != null)
                    {
                        Relatorio_Enc.Items.Add("Registro: " + c++);
                        Relatorio_Enc.Items.Add("Idade: " + atual.idade); ;
                        Relatorio_Enc.Items.Add("Nome: " + atual.nome);
                        Relatorio_Enc.Items.Add("Gênero: " + atual.sexo);
                        Relatorio_Enc.Items.Add(" - - - - - - - ");
                        atual = atual.prox;
                    }
                }
            }
        }
    }

}
