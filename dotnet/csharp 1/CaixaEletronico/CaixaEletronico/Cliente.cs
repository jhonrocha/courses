using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Cliente
    {
        public string nome;

        public string cpf;

        public string rg;

        public string endereco;

        int idade;

        public bool EhMaiorDeIdade()
        {
            return this.idade >= 18;
        }
    }
}
