using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ICloneableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            SqlConnection sqlConn = new SqlConnection();

            CloneMe(myString);
            CloneMe(unixOS);
            CloneMe(sqlConn);

            Console.ReadLine();
        }

        private static void CloneMe(ICloneable c)
        {
            object theClone = c.Clone();
            Console.WriteLine("Your clone is a: {0}", theClone.GetType().Name);
        }
    }
}
