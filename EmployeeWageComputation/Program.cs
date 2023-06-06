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

            IEmpWageCalculator empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompanyEmpWage("Company1", 20, 20, 100);
            empWageBuilder.AddCompanyEmpWage("Company2", 25, 22, 110);

            empWageBuilder.CalculateEmployeeWage();

            // Query the total wage for a specific company
            string companyToQuery = "Company1";
            int totalWage = empWageBuilder.GetTotalWageByCompany(companyToQuery);
            Console.WriteLine("Total wage for {0}: {1}", companyToQuery, totalWage);

            Console.ReadLine();
        }
    }


}