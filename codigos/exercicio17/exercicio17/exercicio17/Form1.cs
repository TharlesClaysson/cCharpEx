using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class tp_no
        {
            public string nome, idade, genero;
            public tp_no prox;
        }
        tp_no topo = null, atual = null, anterior = null;

        void Insere(ref tp_no t, string n, string i, string g)
        {
            tp_no no = new tp_no();
            no.nome = n;
            no.idade = i;
            no.genero = g;
            if (t != null)
                no.prox = t;
            t = no;
        }

        bool buscou;
        private void B_Procurar_A_Click(object sender, EventArgs e)
        {
            Procura(topo, TB_NomeProc_A.Text, ref atual, ref anterior);
            if (atual != null)
            {
                TB_Nome_A.Text = atual.nome;
                TB_Idade_A.Text = atual.idade;
                CB_A.Text = atual.genero;
                TB_Nome_A.Focus();
                buscou = true;
            }
            else
            {
                MessageBox.Show("Não encontrado");
                TB_NomeProc_A.Clear();
                TB_NomeProc_A.Focus();
                buscou = false;
            }
        }

        private void B_Altera_Click(object sender, EventArgs e)
        {
            string Nome = TB_NomeProc_A.Text;
            if (Nome != "" && buscou == true)
            {
                atual.nome = TB_Nome_A.Text;
                atual.idade = TB_Idade_A.Text;
                atual.genero = CB_A.Text;
                MessageBox.Show("Dados alterados com sucesso!");
                TB_Idade_A.Clear();
                TB_Nome_A.Clear();
                buscou = false;
            }
            else
                MessageBox.Show("Para alterar novos dados é necessário fazer nova busca!");
            TB_NomeProc_A.Clear();
            TB_NomeProc_A.Focus();
        }

        private void B_Procurar_E_Click(object sender, EventArgs e)
        {
            Procura(topo, TB_Procurar_E.Text, ref atual, ref anterior);
            if (atual != null)
            {
                TB_Nome_E.Text = atual.nome;
                TB_Idade_E.Text = atual.idade;
                CB_E.Text = atual.genero;
                buscou = true;
            }
            else
            {
                MessageBox.Show("Não encontrado");
                TB_Procurar_E.Clear();
                TB_Procurar_E.Focus();
                buscou = false;
            }
        }

        private void B_Exclui_Click(object sender, EventArgs e)
        {
            string Nome = TB_Procurar_E.Text;
            if (Nome != "" && buscou == true)
            {
                if (atual == topo) 
                {
                    topo = atual.prox;  
                    atual.prox = null;
                }
                else if (atual.prox == null) 
                {
                    anterior.prox = null;
                }
                else  
                {
                    anterior.prox = atual.prox;
                    atual.prox = null;
                }
                MessageBox.Show("Dados Excluidos com sucesso!");
                buscou = false;
            }
            else
                MessageBox.Show("Para excluir novos dados é necessário fazer uma nova busca!");
            TB_Idade_E.Clear();
            TB_Nome_E.Clear();
            TB_Procurar_E.Clear();
            TB_Procurar_E.Focus();
        }

        private void B_Exibe_Click(object sender, EventArgs e)
        {
            int i = 1;
            atual = topo;
            LB_Relatorio.Items.Clear();
            while (atual != null)
            {
                LB_Relatorio.Items.Add("Registro: " + i);
                LB_Relatorio.Items.Add("Nome: " + atual.nome);
                LB_Relatorio.Items.Add("Idade: " + atual.idade);
                LB_Relatorio.Items.Add("Gênero: " + atual.genero);
                LB_Relatorio.Items.Add(" - - - - - - - ");

                atual = atual.prox;
                i++;
            }
        }

        private void B_Inclui_Click(object sender, EventArgs e)
        {
            string Nome = TB_Nome_I.Text;
            if (Nome != "")
            {
                Insere(ref topo, TB_Nome_I.Text, TB_Idade_I.Text, CB_I.Text);
                MessageBox.Show("Dados cadastrados com sucesso!");
                TB_Idade_I.Clear();
                TB_Nome_I.Clear();
                TB_Nome_I.Focus();
            }
            else
                MessageBox.Show("Você precisa completar todos os campos!");
        }

        void Procura(tp_no t, string nomeProc, ref tp_no a, ref tp_no ant)
        {
            ant = null;
            a = t;
            while (a != null && nomeProc != a.nome)
            {
                ant = a;
                a = a.prox;
            }
        }
    }
}
