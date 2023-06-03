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
            //Company 1
            Console.WriteLine("Employee wage for company1 is:- \n");
            int empRatePerHourCompany1 = 20;
            int maxWorkingDaysCompany1 = 20;
            int maxWorkingHrsCompany1 = 100;

            EmployeeWageCalculator.CalculateEmployeeWage(empRatePerHourCompany1, maxWorkingDaysCompany1, maxWorkingHrsCompany1);

            Console.WriteLine("Employee wage for company2 is:- \n");
            //Company 1
            int empRatePerHourCompany2 = 25;
            int maxWorkingDaysCompany2 = 22;
            int maxWorkingHrsCompany2 = 110;

            EmployeeWageCalculator.CalculateEmployeeWage(empRatePerHourCompany2, maxWorkingDaysCompany2, maxWorkingHrsCompany2);


        }
    }


}