using Animais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Models.Animais
{
    internal class Arara : Ave, IVoar, IOviparo
    {
        public Arara()
        {
            Console.WriteLine("Uma arara foi criada.");
        }

        public double VelocidadeVoo { get; set; }
        public int AltitudeMaximaMetros { get; set; }

        public void Botar()
        {
            Console.WriteLine("A arara está botando ovos.");
        }

        public void Chocar()
        {
            Console.WriteLine("A arara está chocando ovos.");
        }

        public void Voar()
        {
            Console.WriteLine("A arara está voando.");
        }
    }
}
