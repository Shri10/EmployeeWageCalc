using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalc
{
    internal class Employee
    {
        public const int FULLTIME = 1;
        public const int PARTTIME = 2;

        public void ComputeEmpWageForCompany(Company company)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int totalWrkHrs = 0;
            int day = 1;

            Random random = new Random();

            while (day <= company.MaxWorkingDays && totalWrkHrs <= company.MaxWorkingHours)
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

                empWage = company.EmpRatePerHour * empHrs;
                totalWage += empWage;
                totalWrkHrs += empHrs;
                day++;
            }

            company.TotalWage = totalWage;
        }
    }
}
