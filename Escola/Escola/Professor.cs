using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Professor: Pessoa
    {
        public void Explicar(string assunto)
        {
            Console.WriteLine($"Esta é uma explicação sobre o assunto {assunto}.");
        }
    }
}
