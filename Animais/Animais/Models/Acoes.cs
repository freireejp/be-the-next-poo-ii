using Animais.Models.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Models
{
    internal class Acoes
    {
        List<Animal> animais = new List<Animal>
        {
            new Leao(),
            new Chacal(),
            new Morcego(),
            new Cisne(),
            new Arara(),
            new DragaoDeComodo(),
            new Lontra(),
            new Pinguim(),
            new Coruja(),
            new Elefante(),
            new Jacare(),
        };

        public void ExecutarAcoes()
        {
            Console.WriteLine();

            foreach (var animal in animais)
            {
                Console.WriteLine($"Ações do(a) { animal.GetType().Name }:");
                animal.Alimentar();
                animal.Comunicar();
                animal.Movimentar();

                Console.WriteLine();
            }
        }
    }
}
