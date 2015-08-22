using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;
        protected static string companyName;

        protected BenefitPackage empBenefits = new BenefitPackage();

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
            private set { empSSN = value; }
        }

        public static string Company
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }

        //Métodos
        public virtual void GiveBonus(float amount) 
        {
            currPay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("Pay: {0}", currPay);
            Console.WriteLine("Company: {0}", Company);
            Console.WriteLine("SocialSecurityNumber: {0}", SocialSecurityNumber);
        }

        public double GetBenefitCost()
        {
            return empBenefits.ComputerPayDeduction();
        }


        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }

            public double ComputerPayDeduction()
            {
                return 125.0;
            }
        }

    }
}
