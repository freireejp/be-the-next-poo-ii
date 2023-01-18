using Animais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Models.Animais
{
    internal class Pinguim : Ave, IAquatico
    {
        public Pinguim()
        {
            Console.WriteLine("Um pinguim foi criado.");
        }

        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
    }
}
