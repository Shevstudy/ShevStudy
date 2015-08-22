using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson danny = new SalesPerson();

            danny.Age = 31;
            danny.Name = "Danny";
            danny.SalesNumber = 50;

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);

            chucky.GiveBonus(300);

            double cost = chucky.GetBenefitCost();

            chucky.DisplayStats();

            Console.WriteLine("Benefícios: {0}", cost);

            Employee.BenefitPackage.BenefitPackageLevel myBenefitLevel = Employee.BenefitPackage.BenefitPackageLevel.Platinum;

            Console.WriteLine("Level: {0}", myBenefitLevel);

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);

            fran.GiveBonus(200);

            fran.DisplayStats();

            try
            {

                PTSalesPerson ptSales = ((PTSalesPerson)danny);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            PTSalesPerson ptCast = danny as PTSalesPerson;

            if (ptCast == null)
            {
                Console.WriteLine("Sorry, danny is not PTSalesPerson");
            }

            Console.WriteLine(danny.ToString() + "&&" + danny.GetType());

            Console.ReadLine();


        }

        public void CastingExamples()
        {
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            GivePromotion((Manager)frank);

            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);

            SalesPerson jill = new PTSalesPerson("Jill", 834, 3001, 100000, "111-12-1119", 90);
            GivePromotion(jill);
        }

        public static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted", emp.Name);

            if (emp is SalesPerson)
            {
                Console.WriteLine("{0} made {1} salaes(s)!", emp.Name, ((SalesPerson)emp).SalesNumber);
            }

            if (emp is Manager)
            {
                Console.WriteLine("{0} had {1} stock options...", emp.Name, ((Manager)emp).StockOptions);
            }
        }
    }
}
