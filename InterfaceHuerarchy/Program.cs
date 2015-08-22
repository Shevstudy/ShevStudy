using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHuerarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150);
            myBitmap.DrawUpsideDown();

            IAdvancedDraw iAdvDraw;
            iAdvDraw = (IAdvancedDraw)myBitmap;
            iAdvDraw.DrawUpsideDown();

            Console.ReadLine();
        }
    }
}
