using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Cumprimentar()
        {
            Console.WriteLine($"Olá! Prazer, meu nome é {Nome}.");
        }

        public void DizerIdade()
        {
            Console.WriteLine($"Eu tenho {this.Idade} anos.");
        }
    }
}
