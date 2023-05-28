using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalc
{
    internal class Employee
    {
        public const int FULLTIME = 1;
        public const int PARTTIME = 2;

        public void ComputeEmpWageForCompany(string companyName, int EMP_RATE_PER_HR, int MAX_WORKING_DAYS, int MAX_WORKING_HOURS)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int totalWrkHrs = 0;
            int day = 1;

            Random random = new Random();

            while (day <= MAX_WORKING_DAYS && totalWrkHrs <= MAX_WORKING_HOURS)
            {
                int randomInput = random.Next(0, 3);

                switch (randomInput)
                {
                    case FULLTIME:
                        empHrs = 8;
                        break;
                    case PARTTIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                empWage = EMP_RATE_PER_HR * empHrs;
                totalWage += empWage;
                totalWrkHrs += empHrs;
                day++;
            }

            Console.WriteLine($"Total Employee Wage for {companyName} is {totalWage}");
        }
    }
}
