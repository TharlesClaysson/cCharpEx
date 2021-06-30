using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int funcao1(int num)
        {
            // Tipos de Dados Primitivos
            // inteiro, decimal, caracter, cadeira de caracteres, lógico
            // int      float    char      string                 bool
            // Declarar Variáveis
            int x, y;
            double z;
            char carac;

            // Operadores
            // Aritméticos: +, -, *, /, %
            // Relacionais: >, <, >=, <=, !=, ==
            // Lógicos: && (e), || (ou), ! (não)
            // Atribuição: =
            x = 10; y = 5;
            z = 3.80;
            carac = 'A';
            string nome = "Marcelo";

            //Expressões
            z = x + y;
            bool a = x > 11 || y == 5;

            // Comando decisão
            if (num % 2 == 0)
                y = num + x;
            else
                y = num + x * 2;

            return y;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        class TAD
        {

            public int idade;
            public string nome;
        }

        private void B_Processa_Click(object sender, EventArgs e)
        {
            int numero, retorno;
            numero = Convert.ToInt32(TB_Entrada.Text);
           
            retorno = funcao1(numero);

            TB_Saida.Text = Convert.ToString(retorno);

            // Comando de repetição
            int i;
            for (i=1; i<=5; i+=1)
            {
                listBox1.Items.Add(i);
            }

            while (i<=10)
            {
                listBox1.Items.Add(i);
                i+=1; // i = i + 1;  i += 1;
            }

            // Variáveis indexadas
            int[] vetor = new int[10];

            vetor[0] = 5;
            vetor[1] = 67;
            vetor[9] = 2;

            i = vetor[1];

            listBox1.Items.Add(vetor[9]);

            TAD registro = new TAD();
            
            registro.idade = 20;
            registro.nome = "Pedro";

            listBox1.Items.Add(registro.idade + " " + registro.nome);

        }


    }
}
