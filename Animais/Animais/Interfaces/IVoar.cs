using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Interfaces
{
    internal interface IVoar
    {
        double VelocidadeVoo { get; set; }
        int AltitudeMaximaMetros { get; set; }
        void Voar();
    }
}
