using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIniciando
{
   public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numero) : base(numero){ }

        public ContaPoupanca()
        {
            // TODO: Complete member initialization
        }

        public override void Saca(double valor)
        {
            this.Saldo -= (valor + 0.10);
        }

    }
}
