using Animais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Models.Animais
{
    internal class Coruja : Ave, IVoar, IOviparo
    {
        public Coruja()
        {
            Console.WriteLine("Uma coruja foi criada.");
        }

        public double VelocidadeVoo { get; set; }
        public int AltitudeMaximaMetros { get; set; }

        public void Botar()
        {
            Console.WriteLine("A coruja está botando ovos.");
        }

        public void Chocar()
        {
            Console.WriteLine("A coruja está chocando ovos.");
        }

        public void Voar()
        {
            Console.WriteLine("A coruja está voando.");
        }
    }
}
