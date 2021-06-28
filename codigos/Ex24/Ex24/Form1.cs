using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class tp_no
        {
            public tp_no esq;
            public int valor;
            public tp_no dir;
        }
        tp_no raiz = null;

        void Insere(ref tp_no r, int x)
        {
            if (r == null)
            {
                r = new tp_no();
                r.valor = x;
            }
            else if (x < r.valor)
                Insere(ref r.esq, x);
            else
                Insere(ref r.dir, x);
        }

        tp_no Busca(tp_no r, int x)
        {
            if (r == null)
                return null;
            else if (x == r.valor)
                return r;
            else if (x < r.valor)
                return Busca(r.esq, x);
            else
                return Busca(r.dir, x);
        }

        tp_no RetornaMaior(ref tp_no r)
        {
            if (r.dir == null)
            {
                tp_no p = r;
                r = r.esq;
                return p;
            }
            else
                return RetornaMaior(ref r.dir);
        }

        tp_no Remove(ref tp_no r, int x)
        {
            if (r == null)      // elemento nao encontrado
                return null;
            else if (x == r.valor)    // elemento encontrado
            {
                tp_no p = r;
                if (r.esq == null)        // nao tem filho esquerdo
                    r = r.dir;
                else if (r.dir == null)  // nao tem filho direito
                    r = r.esq;
                else                          // tem ambos os filhos
                {
                    p = RetornaMaior(ref r.esq);
                    r.valor = p.valor;
                }
                return p;
            }
            else if (x < r.valor)
                return Remove(ref r.esq, x);      // procura na subarvore esquerda
            else
                return Remove(ref r.dir, x);       // procura na subarvore direta
        }

        void EmOrdem(tp_no r)
        {
            if (r != null)
            {
                EmOrdem(r.esq);
                LB_Resultados.Items.Add(r.valor);
                EmOrdem(r.dir);
            }
        }

        void PreOrdem(tp_no r)
        {
            if (r != null)
            {
                LB_Resultados.Items.Add(r.valor);
                PreOrdem(r.esq);
                PreOrdem(r.dir);
            }
        }

        void PosOrdem(tp_no r)
        {
            if (r != null)
            {
                PosOrdem(r.esq);
                PosOrdem(r.dir);
                LB_Resultados.Items.Add(r.valor);
            }
        }

        private void B_Insere_Click(object sender, EventArgs e)
        {
            string valor = TB_Insere.Text;
            if (valor != "")
            {
                Insere(ref raiz, Convert.ToInt32(TB_Insere.Text));
                TB_Insere.Clear();
            }
            else
                MessageBox.Show("Você precisa inserir um valor!");
             TB_Insere.Focus();
        }

        private void B_Pesquisa_Click(object sender, EventArgs e)
        {
            string valor = TB_Insere.Text;
            tp_no resp;
            if (valor != "")
            {
                    resp = Busca(raiz, Convert.ToInt32(TB_Insere.Text));
                if (resp != null)
                {
                    LB_Resultados.Items.Clear();
                    MessageBox.Show("Valor encontrado!");
                    LB_Resultados.Items.Add(resp.valor);
                }
                else
                {
                    MessageBox.Show("Valor não encontrado!");
                    TB_Insere.Clear();
                }
            }
            else
                MessageBox.Show("Você precisa inserir um valor!");
            TB_Insere.Focus();
        }

        private void B_Remove_Click(object sender, EventArgs e)
        {
            string valor = TB_Insere.Text;
            tp_no resp;
            if (valor != "")
            {
                resp = Busca(raiz, Convert.ToInt32(TB_Insere.Text));
                if (resp != null)
                {
                    resp = Remove(ref raiz, Convert.ToInt32(TB_Insere.Text));
                    MessageBox.Show("Item excluido com sucesso!");
                    TB_Insere.Clear();
                }
                else
                {
                    MessageBox.Show("Você esta tentando excluir um item que não existe cabeçudo!");
                    TB_Insere.Clear();
                }
            }
            else
                MessageBox.Show("Você precisa inserir um valor!");
            TB_Insere.Focus();
            LB_Resultados.Items.Clear();
        }

        private void B_Exibir_Click(object sender, EventArgs e)
        {
            LB_Resultados.Items.Clear();
            if (RB_Pos.Checked == true)
                PosOrdem(raiz);
            else if (RB_Pre.Checked == true)
                PreOrdem(raiz);
            else if (RB_Ordem.Checked == true)
                EmOrdem(raiz);
            else
                MessageBox.Show("Você precisa escolher uma das três ordens de execução!");
        }
    }
}
