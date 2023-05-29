using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalc
{
    internal class CompanyEmpWage
    {
        public string CompanyName { get; set; }
        public int EmpRatePerHr { get; set; }
        public int MaxWorkingDays { get; set; }
        public int MaxWorkingHrs { get; set; }
        public int TotalWage { get; set; }

        public CompanyEmpWage(string companyName, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            CompanyName = companyName;
            EmpRatePerHr = empRatePerHr;
            MaxWorkingDays = maxWorkingDays;
            MaxWorkingHrs = maxWorkingHrs;
            TotalWage = 0;
        }

        public void SetTotalWage(int totalWage)
        {
            TotalWage = totalWage;
        }

        public string ToString()
        {
            return $"Total Employee Wage for {CompanyName} is {TotalWage}";
        }

    }
}
