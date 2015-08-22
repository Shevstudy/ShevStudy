using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Hexagon hex = new Hexagon();
            Console.WriteLine(hex.Points);            

            Circle c = new Circle();
            IPointy itfPt = null;

            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Hexagon hex2 = new Hexagon();

            IPointy itfPt2 = hex as IPointy;

            if (itfPt2 != null)
            {
                Console.WriteLine(itfPt2.Points);
            }
            else
            {
                Console.WriteLine("Oops, not Pointy...");
            }

            Shape[] myShapes = { new Hexagon(), new Circle(), new ThreeDCircle(), new Triangle("Joe"), new Circle("JoJo") };

            for (int i = 0; i < myShapes.Length; i++)
            {
                myShapes[i].Draw();

                if (myShapes[i] is IPointy)
                {
                    Console.WriteLine("-> Points: {0}", ((IPointy)myShapes[i]).Points);
                }
                else
                {
                    Console.WriteLine("->{0}\'s not pointy!", myShapes[i].PetName);
                }
            }

            Shape[] myShapes2 = { new Hexagon(), new Circle(), new Triangle(), new Circle("JoJo2") };

            for (int b = 0; b < myShapes2.Length; b++)
            {
                if (myShapes2[b] is IDraw3D)
                {
                    DrawIn3D((IDraw3D)myShapes2[b]);
                }
            }

            IPointy firtPointInShapes = FindFirstPointyShape(myShapes);
            Console.WriteLine("The item has {0} points", firtPointInShapes.Points);

            Console.ReadLine();
        }

        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy)
                {
                    return s as IPointy;
                }
            }
            return null;
        }
    }
}
