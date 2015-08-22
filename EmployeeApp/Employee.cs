using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;
        private static string companyName;

        //Construtores
        public Employee() { }

        public Employee(string name, int id, float pay)
            :this(name, 0, id, pay, "") { }

        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            ID = id;
            Pay = pay;
            Age = age;
            SocialSecurityNumber = ssn;
        }

        static Employee()
        {
            companyName = "My Company";
        }

        //Propriedades
        public string Name
        {
            get { return Name; }
            set
            {
                if (value.Length > 10)
                {
                    Console.WriteLine("Error! Name must be less than 16 charachters!");
                }
                else 
                {
                    empName = value;
                }
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
            set { empSSN = value; }
        }

        public static string Company
        {
            get { return companyName; }
            set { companyName = value; }
        }

        //Métodos
        public void GiveBonus(float amount) 
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("Pay: {0}", currPay);
        }
    }
}
