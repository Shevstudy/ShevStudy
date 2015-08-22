using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterfaceHierarchy
{
    class Rectangle: IShape
    {

        int IShape.GetNumberOfSides()
        {
            return 4;
        }

        void IDrawable.Draw()
        {
            Console.WriteLine("Drawing in a screen...");
        }

        void IPrintable.Print()
        {
            Console.WriteLine("Printing..."); 
        }

        void IPrintable.Draw()
        {
            Console.WriteLine("Drawing in a Print...");
        }
    }
}
