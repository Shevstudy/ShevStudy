using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson() { }

        public PTSalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numberOfSales)
            :base(fullName, age, empID, currPay, ssn, numberOfSales)
        {

        }
    }
}
