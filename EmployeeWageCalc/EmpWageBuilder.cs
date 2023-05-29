using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalc
{
    internal class EmpWageBuilder
    {
        public const int FULLTIME = 1;
        public const int PARTTIME = 2;

        private List<CompanyEmpWage> companyEmpWages;

        public EmpWageBuilder()
        {
            companyEmpWages = new List<CompanyEmpWage>();
        }

        public void AddCompanyEmpWage(string companyName, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyName, empRatePerHr, maxWorkingDays, maxWorkingHrs);
            companyEmpWages.Add(companyEmpWage);
        }

        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in companyEmpWages)
            {
                companyEmpWage.SetTotalWage(this.ComputeEmpWageForCompany(companyEmpWage));
                Console.WriteLine(companyEmpWage.ToString());
            }
        }

        //public void ComputeEmpWageForCompany(Company company)
        public int ComputeEmpWageForCompany(Company company)
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
            return totalWage;
        }
    }
}
