using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Models
{
    internal class Ave : Animal
    {
        public bool Rapina { get; set; }
        public bool CorPena { get; set; }

        public void Ciscar()
        {
            Console.WriteLine("A ave está ciscando.");
        }
    }
}
