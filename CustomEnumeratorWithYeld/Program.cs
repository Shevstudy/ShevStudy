using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYeld
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage carLot = new Garage();

            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed);
            }

            Console.WriteLine();

            foreach(Car c in carLot.GetTheCars(true))
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed);
            }

            Console.ReadLine();
        }
    }
}
