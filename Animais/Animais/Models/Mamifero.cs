using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Models
{
    internal class Mamifero : Animal
    {
        public int QuantidadeMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorDoPelo { get; set; }

        public void Amamentar()
        {
            Console.WriteLine("O mamífero está amamentando.");
        }
    }
}
