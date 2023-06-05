using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilder
    {
        private readonly int empRatePerHour;
        private readonly int maxWorkingDays;
        private readonly int maxWorkingHrs;
        private int totalWage;

        public EmpWageBuilder(int empRatePerHour, int maxWorkingDays, int maxWorkingHrs)
        {
            this.empRatePerHour = empRatePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
            totalWage = 0;
        }

        public void CalculateEmployeeWage()
        {
            int empHrs;
            int empWage;
            int day = 1;
            int totalHrs = 0;
            Random random = new Random();

            while (day <= maxWorkingDays && totalHrs < maxWorkingHrs)
            {
                int randomInput = random.Next(0, 3);

                switch (randomInput)
                {
                    case 0:
                        empHrs = 8; // Full-time hours
                        Console.WriteLine("Full-time Employee is present");
                        break;
                    case 1:
                        empHrs = 4; // Part-time hours
                        Console.WriteLine("Part-time Employee is present");
                        break;
                    default:
                        empHrs = 0; // Absent hours
                        Console.WriteLine("Employee is Absent");
                        break;
                }

                empWage = empHrs * empRatePerHour;
                totalWage += empWage;
                totalHrs += empHrs;
                Console.WriteLine("Employee Wage per day {0}:{1}", day, empWage);
                day++;
            }

            Console.WriteLine("Total wage for {0} days and {1} hours is: {2}", (day - 1), totalHrs, totalWage);
        }

        public int GetTotalWage()
        {
            return totalWage;
        }
    }
}