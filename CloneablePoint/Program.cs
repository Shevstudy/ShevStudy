using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(50, 50);
            Point p2 = p1;

            p2.X = 0;
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Point p3 = new Point(100, 100);
            Point p4 = (Point)p3.Clone();

            p4.X = 0;

            Console.WriteLine(p3);
            Console.WriteLine(p4);

            Console.WriteLine();

            Point p5 = new Point(100, 100, "Jane");
            Point p6 = (Point)p5.Clone();

            Console.WriteLine("Before modification:");
            Console.WriteLine("p5: {0}", p5);
            Console.WriteLine("p6: {0}", p6);

            p6.desc.PetName = "My new Point";
            p6.X = 9;

            Console.WriteLine("\nChanged p6.desc.petName and p6.X");
            Console.WriteLine("After modification");

            Console.WriteLine("p5: {0}", p5);
            Console.WriteLine("p6: {0}", p6);

            Console.ReadLine();
        }
    }
}
