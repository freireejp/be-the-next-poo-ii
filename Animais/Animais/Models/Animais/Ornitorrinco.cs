﻿using Animais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Models.Animais
{
    internal class Ornitorrinco : Mamifero, IAquatico
    {
        public Ornitorrinco()
        {
            Console.WriteLine("Um ornitorrinco foi criado.");
        }

        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
    }
}
