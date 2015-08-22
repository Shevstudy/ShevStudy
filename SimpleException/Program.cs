using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Zippy", 20);

            myCar.CranckTunes(true);

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Method: {0}", ex.TargetSite);
                Console.WriteLine("Class: {0}", ex.TargetSite.DeclaringType);
                Console.WriteLine("Type: {0}", ex.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("Source: {0}", ex.Source);
                Console.WriteLine("Link: {0}\n", ex.HelpLink);
                
                if (ex.Data != null)
                {
                    foreach (DictionaryEntry de in ex.Data)
                    {
                        Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
                    }
                }

                Console.WriteLine("StackTrace: {0}", ex.StackTrace);
            }

            Console.WriteLine("\n******** Out of exception logic ********");
            Console.ReadLine();
        }
    }
}
