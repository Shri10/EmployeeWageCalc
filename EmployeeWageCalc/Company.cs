using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalc
{
    internal class Company
    {
        public string CompanyName { get; set; }
        public int EmpRatePerHour { get; set; }
        public int MaxWorkingDays { get; set; }
        public int MaxWorkingHours { get; set; }
        public int TotalWage { get; set; }

    }
}
