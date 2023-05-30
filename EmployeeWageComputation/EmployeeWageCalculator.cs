using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWageCalculator
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;

        public static void CalculateEmployeeWage()
        {
            int totalWage = 0;
            int empHrs;
            int empWage;
            int day = 1;
            int totalHrs = 0;
            Console.WriteLine("Welcome to Employee Wage Computation");
            Random random = new Random();

            while (day <= MAX_WORKING_DAYS && totalHrs < MAX_WORKING_HRS)
            {
                int randomInput = random.Next(0, 3);

                switch (randomInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("Full-time Employee is present");
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("Part-time Employee is present");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }

                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalWage += empWage;
                totalHrs += empHrs;
                Console.WriteLine("Employee Wage per day {0}:{1}", day, empWage);
                day++;
            }

            Console.WriteLine("Total wage for {0} days and {1} hours is: {2}", (day - 1), totalHrs, totalWage);
            Console.ReadLine();
        }
    }
}
