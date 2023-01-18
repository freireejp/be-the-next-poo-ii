using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Models
{
    internal abstract class Animal
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }
        public bool Carnivoro { get; set; }
        public bool Peconhento { get; set; }

        public void Movimentar()
        {
            Console.WriteLine("O animal está se movimentando.");
        }

        public void Comunicar()
        {
            Console.WriteLine("O animal está se comunicando.");
        }

        public void Alimentar()
        {
            Console.WriteLine("O animal está se alimentando.");
        }
    }
}
