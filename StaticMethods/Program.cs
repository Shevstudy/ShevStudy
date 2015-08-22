using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FUN WITH STATICS");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Teenager.Complain());
            }

            Console.ReadLine();
        }
    }
}
