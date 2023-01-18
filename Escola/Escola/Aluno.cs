using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Aluno: Pessoa
    {
        public void IrParaEscola()
        {
            Console.WriteLine($"O aluno foi para a escola.");
        }
    }
}
