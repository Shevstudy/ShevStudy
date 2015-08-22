using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    class Teenager
    {
        public static Random r = new Random();

        public static int GetRandomNumber(short upperLimit)
        {
            return r.Next(upperLimit);
        }

        public static string Complain()
        {
            string[] messages = { "Do I have to?", "He started it!", "I'm too tired...", "I hate school!", "You are sooooo wrong!" };

            return messages[GetRandomNumber(5)];
        }
    }
}
