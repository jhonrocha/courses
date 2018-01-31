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
            Conta guilherme = new Conta();
            Conta mauricio = new Conta();

            guilherme.saldo = 1500.0;
            mauricio.saldo = 2000.0;

            guilherme.Transfere(200.0, mauricio);

            MessageBox.Show("O saldo de Guilherme é : " + guilherme.saldo);
            MessageBox.Show("O saldo de Mauricio é : " + mauricio.saldo);



        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            Cliente cliente = new Cliente();

            conta.cliente = cliente;

            cliente.nome = "Victor";
            cliente.rg = "123456789";

            MessageBox.Show(conta.cliente.nome);
            MessageBox.Show(conta.cliente.rg);

        }
    }
}
