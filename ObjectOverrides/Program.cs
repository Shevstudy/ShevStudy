using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with System.Object");

            Person p1 = new Person();
            Person p2 = p1;
            object o = p2;

            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same Instance");
            }

            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("GetHashCode: {0}", p1.GetHashCode());
            Console.WriteLine("GetType: {0}", p1.GetType());

            Console.ReadLine();
        }
    }
}
