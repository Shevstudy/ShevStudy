﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomEnumeratorWithYeld
{
    class Radio
    {
        public void TurnOn(bool on)
        {
            if (on)
            {
                Console.WriteLine("Jamming...");
            }
            else
            {
                Console.WriteLine("QUiet Time...");
            }
        }
    }
}