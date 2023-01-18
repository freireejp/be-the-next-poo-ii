using Animais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Models.Animais
{
    internal class DragaoDeComodo : Reptil, IOviparo
    {
        public DragaoDeComodo()
        {
            Console.WriteLine("Um dragão de comodo foi criado.");
        }

        public void Botar()
        {
            Console.WriteLine("O dragão de comodo está botando ovos.");
        }

        public void Chocar()
        {
            Console.WriteLine("O dragão de comodo está chocando ovos.");
        }
    }
}
