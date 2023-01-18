using Animais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Models.Animais
{
    internal class Morcego : Mamifero, IVoar
    {
        public Morcego()
        {
            Console.WriteLine("Um morcego foi criado.");
        }

        public double VelocidadeVoo { get; set; }
        public int AltitudeMaximaMetros { get; set; }

        public void Voar()
        {
            Console.WriteLine("O morcego está voando.");
        }
    }
}
