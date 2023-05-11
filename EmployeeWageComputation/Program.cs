using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_DAY = 20;
            int empHrs = 0;
            int empWage = 0;
            Console.WriteLine("Welocme to the EmployeeWageComputation");
            Random random = new Random();
            int randomInput = random.Next(0, 3);
            if (FULL_TIME == randomInput)
            {
                empHrs = 8;
                Console.WriteLine("FullTime employee is present");
            }
            else if (PART_TIME == randomInput)
            {
                empHrs = 4;
                Console.WriteLine("PartTime employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            empWage = EMP_RATE_PER_DAY * empHrs;
            Console.WriteLine("Employee Wage per day:{0}",empWage);
            Console.ReadLine();
        }
    }
}
