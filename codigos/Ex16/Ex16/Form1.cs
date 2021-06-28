using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class tp_no
        {
            public int valor;
            public tp_no prox;
        }

        void Insere(ref tp_no t, int valor)
        {
            tp_no no = new tp_no();
            no.valor = valor;
            if (t != null)
                no.prox = t;
            t = no;
        }

        tp_no Remove(ref tp_no t)
        {
            tp_no no = null;
            if (t != null)
            {
                no = t;
                t = t.prox;
                no.prox = null;
            }
            return no;
        }
        tp_no topo = null;

      private void B_insere_Click(object sender, EventArgs e)
        {
            if (TB_Numero.Text != "")
            {
                int n = Convert.ToInt32(TB_Numero.Text);
                Insere(ref topo, n);
            }
            else
                MessageBox.Show("Digite um número");

            TB_Numero.Clear();
            TB_Numero.Focus();
        }

        private void B_remove_Click(object sender, EventArgs e)
        {
            tp_no no = Remove(ref topo);
            if (no != null)
            {
                LB.Items.Add(no.valor);
            }
            else
                MessageBox.Show("Lista vazia");
        }
    }
}
