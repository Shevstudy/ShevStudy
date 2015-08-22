using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            //Aloque e configure um objeto Car.
            Car myCar = new Car();

            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            //Aumente a velocidade de car algumas vezes e imprima o novo estado.

            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            Console.WriteLine();

            Car chuck = new Car();

            chuck.PrintState();

            Console.WriteLine();

            //Cria um carro chamado chuck indo a 10MPH
            Car nchuck = new Car();

            nchuck.PrintState();

            Console.WriteLine();

            //Cria um carro chamado Marry indo a 10MPH
            Car mary = new Car("Marry");

            mary.PrintState();

            Console.WriteLine();

            //Cria um carro chamado Daisy indo a 75MPH
            Car daisy = new Car("Daisy", 75);

            daisy.PrintState();

            Console.WriteLine();

            Motorcycle mc = new Motorcycle();

            mc.PopAWheely();

            

            Console.WriteLine("############FUN WITH CTOR##############");

            Motorcycle c = new Motorcycle(5);

            c.SetDriverName("Tiny");
            c.PopAWheely();

            Console.WriteLine("Rider name is{0}", c.driverName);

            Console.WriteLine("############FUN WITH MC2##############");

            Motorcycle2 m1 = new Motorcycle2();
            Console.WriteLine("Name= {0}, Intensity = {1}", m1.driverName, m1.driverIntensity);

            Motorcycle2 m2 = new Motorcycle2(name: "Tiny");
            Console.WriteLine("Name = {0}, Intensity = {1}", m2.driverName, m2.driverIntensity);

            Motorcycle2 m3 = new Motorcycle2(7);
            Console.WriteLine("Name = {0}, Intensity = {1}", m3.driverName, m3.driverIntensity);

            Console.ReadLine();
        }
    }
}
