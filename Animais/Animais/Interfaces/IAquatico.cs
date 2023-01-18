using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Interfaces
{
    internal interface IAquatico
    {
        bool ViveEmTerra { get; set; }
        bool Mergulho { get; set; }
        bool AguaDoce { get; set; }
    }
}
