﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson : Employee
    {
        public SalesPerson() { }

        public SalesPerson(string fullName, int age, int empId, float currPay, string ssn, int numberOfSales)
            : base(fullName, age, empId, currPay, ssn)
        {
            SalesNumber = numberOfSales;
        }

        public int SalesNumber { get; set; }

        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;

            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            
            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Sales: {0}", SalesNumber);
        }
    }
}
