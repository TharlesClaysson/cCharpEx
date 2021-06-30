using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //void == sem retrorno
        int funcao1(int num)
        {
            //Tipos de Ddos primitivos
            //inteiro, decimal, caracter, cadeira de caracteres, lógico
            //int      float             char      string          bool
            // variaveis
            int x, y;
            double z;
            char carac;

            // Operadores 
            // Aritméticos: +, -, *, /,  %
            // Relacionais: >, <, >=, <=, !=, ==
            // Lógicos: && (e), || (ou), ! (não)
            // Atribuuição: =
            x = 10;
            y = 5;
            z = 3.80;
            carac = 'A';
            string nome = "Marcelo";

            // Espressões
            z = x + y;
            bool a = x > 11 || y == 5;

            // Comando de decisão
            if (num % 2 == 0)
                y = num + x;
            // elif se escreve else if (escreve evento aqui)
            else
                y = num + x * 2;

            return y;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void B_processa_Click(object sender, EventArgs e)
        {
            int numero, retorno;
            numero = Convert.ToInt32(TB_entrada.Text);

            retorno = funcao1(numero);

            TB_saida.Text = Convert.ToString(retorno);
            
            // Comando de repetição
            int i;
            for (i=1; i<=5; i+=1)
            {
                listBox1.Items.Add(i);
            }

            while (i<=10)
            {
                listBox1.Items.Add(i);
                i++; // i = i + 1; ou i += 1;
            }

        }

        private void TB_saida_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
