using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Octagon oct = new Octagon();
            //oct.Draw();

            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();

            IDrawToMemory itfMemmory = (IDrawToMemory)oct;
            itfMemmory.Draw();

            IDrawToPrinter itfPrinter = (IDrawToPrinter)oct;
            itfPrinter.Draw();

            ((IDrawToForm)oct).Draw();

            if (oct is IDrawToPrinter)
            {
                ((IDrawToPrinter)oct).Draw();
            }

            Console.ReadLine();
        }
    }
}
