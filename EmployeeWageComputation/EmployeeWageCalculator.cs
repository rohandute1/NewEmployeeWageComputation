﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public interface IEmpWageCalculator
    {
        void AddCompanyEmpWage(string companyName, int empRatePerHour, int maxWorkingDays, int maxWorkingHrs);
        void CalculateEmployeeWage();
    }

    public class CompanyEmpWage
    {
        public string CompanyName { get; set; }
        public int EmpRatePerHour { get; set; }
        public int MaxWorkingDays { get; set; }
        public int MaxWorkingHrs { get; set; }
        public int TotalWage { get; set; }

        public CompanyEmpWage(string companyName, int empRatePerHour, int maxWorkingDays, int maxWorkingHrs)
        {
            CompanyName = companyName;
            EmpRatePerHour = empRatePerHour;
            MaxWorkingDays = maxWorkingDays;
            MaxWorkingHrs = maxWorkingHrs;
            TotalWage = 0;
        }
    }

    public class EmpWageBuilder : IEmpWageCalculator
    {
        private readonly CompanyEmpWage[] companyEmpWages;
        private int numOfCompanies;

        public EmpWageBuilder()
        {
            companyEmpWages = new CompanyEmpWage[5]; // Set the array size as per your requirement
            numOfCompanies = 0;
        }

        public void AddCompanyEmpWage(string companyName, int empRatePerHour, int maxWorkingDays, int maxWorkingHrs)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyName, empRatePerHour, maxWorkingDays, maxWorkingHrs);
            companyEmpWages[numOfCompanies] = companyEmpWage;
            numOfCompanies++;
        }

        public void CalculateEmployeeWage()
        {
            for (int i = 0; i < numOfCompanies; i++)
            {
                CompanyEmpWage companyEmpWage = companyEmpWages[i];
                int empRatePerHour = companyEmpWage.EmpRatePerHour;
                int maxWorkingDays = companyEmpWage.MaxWorkingDays;
                int maxWorkingHrs = companyEmpWage.MaxWorkingHrs;

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
                    companyEmpWage.TotalWage += empWage;
                    totalHrs += empHrs;
                    Console.WriteLine("Employee Wage per day {0}:{1}", day, empWage);
                    day++;
                }

                Console.WriteLine("Total wage for {0} of {1} days and {2} hours is: {3}", companyEmpWage.CompanyName, (day - 1), totalHrs, companyEmpWage.TotalWage);
            }
        }
    }

}