using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public int numero;

        public double saldo;

        public Cliente cliente;

        public void Saca(double valor)
        {
            if ((valor > 0) && (valor <= this.saldo))
            {
                this.saldo -= valor;
            }
        }

        public void Deposita(double valor)
        {
            if(valor > 0)
            {
                this.saldo += valor;
            }
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }

        public double CalculaRendimentoAnual()
        {
            double rendimentoAnual = this.saldo;

            for(int i=1; i <=12; i++)
            {
                rendimentoAnual *= 1.007;
            }

            return rendimentoAnual - this.saldo;
        }
    }
}
