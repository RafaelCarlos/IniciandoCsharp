using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoIniciando
{
    public class Conta
    {
        public Conta()
        {
                
        }

        public Conta(int numero)
        {
            this.Numero = numero;            
        }

        public int Numero { get; set; }

        public double Saldo { get; protected set; }

        public Cliente Titular { get;  private set; }

        public int Tipo { get; set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            if(this.Tipo ==1)
            {
            this.Saldo -= valor + 0.10;
            }
            else
            {
                this.Saldo -= valor;
            }

        }
    }
}
