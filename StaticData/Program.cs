using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########FUN WITH STATICS########");

            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);

            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetIntersetRate());
            
            SavingsAccount s3 = new SavingsAccount(150);

            Console.WriteLine("Interest rate is: {0}", SavingsAccount.GetIntersetRate());

            TimeUtilClass.PrintTime();

            TimeUtilClass.PrintDate();

            Console.ReadLine();
        }
    }
}
