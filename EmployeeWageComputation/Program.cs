using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_DAY = 20;
        public const int MAX_WORKING_DAYS = 20;
        
        static void Main(string[] args)
        {
            int totalWage = 0;
            int empHrs = 0;
            int empWage = 0;
            Console.WriteLine("Welocme to the EmployeeWageComputation");
            Random random = new Random();
            for (int day = 1; day <= MAX_WORKING_DAYS; day++)
            {
                int randomInput = random.Next(0, 3);
                switch (randomInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("FullTime Employee is present");
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("Part_Time Employee is present");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_DAY;
                totalWage = totalWage + empWage;
                Console.WriteLine("Employee Wage per day {0}:{1}", day, empWage);
            }
            Console.WriteLine("totalWage for {0} days is:{1}",MAX_WORKING_DAYS, totalWage);
            Console.ReadLine();
        }
    }
}