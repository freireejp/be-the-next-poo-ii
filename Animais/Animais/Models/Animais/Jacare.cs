using Animais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Models.Animais
{
    internal class Jacare : Reptil, IOviparo
    {
        public Jacare()
        {
            Console.WriteLine("Um jacaré foi criado.");
        }

        public void Botar()
        {
            Console.WriteLine("O jacaré está botando ovos.");
        }

        public void Chocar()
        {
            Console.WriteLine("O jacaré está chocando ovos.");
        }
    }
}
