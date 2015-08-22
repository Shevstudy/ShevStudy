using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Employee.Classes;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson danny = new SalesPerson();

            danny.Age = 31;
            danny.Name = "Danny";
            danny.SalesNumber = 50;

            Console.ReadLine();
        }
    }
}
