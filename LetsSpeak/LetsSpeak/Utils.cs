using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsSpeak
{
    internal class Utils
    {
        public static bool SomenteLetras(string palavra)
        {
            bool result = palavra.All(c => Char.IsLetter(c));
            return result;
        }
    }
}
