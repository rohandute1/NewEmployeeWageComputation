using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation\n");

            // Company 1
            Console.WriteLine("Employee wage for company1 is:\n");
            EmpWageBuilder company1 = new EmpWageBuilder(20, 20, 100);
            company1.CalculateEmployeeWage();
            int totalWageCompany1 = company1.GetTotalWage();

            Console.WriteLine("\nEmployee wage for company2 is:\n");
            // Company 2
            EmpWageBuilder company2 = new EmpWageBuilder(25, 22, 110);
            company2.CalculateEmployeeWage();
            int totalWageCompany2 = company2.GetTotalWage();

            Console.WriteLine("\nTotal wage for company1: {0}", totalWageCompany1);
            Console.WriteLine("Total wage for company2: {0}", totalWageCompany2);
            Console.ReadLine();
        }
    }


}