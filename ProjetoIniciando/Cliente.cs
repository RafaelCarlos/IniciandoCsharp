using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoIniciando
{
    public class Cliente
    {
       
        public Cliente(string nome)
        {
            // TODO: Complete member initialization
            this.Nome = nome;
        }

        public string Nome { get; set; }

        public Cliente Titular { get; set; }
    }
}
