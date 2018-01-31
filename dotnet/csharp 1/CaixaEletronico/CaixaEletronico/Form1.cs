using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroDaConta;
            numeroDaConta = 1;

            double saldo = 110.0;
            double valor = 10.0;
            bool podeSacar = (valor <= saldo) && (valor > 0.0);
            if (podeSacar)
            {
                saldo = saldo - valor;
                MessageBox.Show("Saque Realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valorInvestido = 2000.0;
            // Repetição com FOR
            for(int i=1; i<= 12; i++)
            {
                valorInvestido *= 1.01;
            }
            MessageBox.Show("O valor investido agora é: " + valorInvestido);

            // Repetição com While
            valorInvestido = 2000.0;
            int j = 1;
            while(j <= 12)
            {
                valorInvestido *= 1.01;
                j++;
            }
            MessageBox.Show("O valor investido agora é: " + valorInvestido);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            umaConta.numero = 1;
            umaConta.titular = "Joaquim José";
            umaConta.saldo = 2000.00;

            Conta outraConta = new Conta();
            outraConta.numero = 2;
            outraConta.titular = "Silva Xavier";
            outraConta.saldo = 1500.0;

            MessageBox.Show("O titular da conta 1 é: " + umaConta.titular);
        }
    }
}
