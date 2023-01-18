using Animais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Models.Animais
{
    internal class Cisne : Ave, IVoar, IOviparo
    {
        public Cisne()
        {
            Console.WriteLine("Um cisne foi criado.");
        }

        public double VelocidadeVoo { get; set; }
        public int AltitudeMaximaMetros { get; set ; }

        public void Botar()
        {
            Console.WriteLine("O cisne está botando ovos.");
        }

        public void Chocar()
        {
            Console.WriteLine("O cisne está chocando ovos.");
        }

        public void Voar()
        {
            Console.WriteLine("O cisne está voando.");
        }
    }
}
