using System;

namespace EmployeeWageCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");

            Employee employee = new Employee();

            string userInput;
            do
            {
                Console.WriteLine("Enter Company Name: ");
                string companyName = Console.ReadLine();

                Console.WriteLine("Enter Employee Rate per Hour: ");
                int empRatePerHr = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Maximum Working Days: ");
                int maxWorkingDays = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Maximum Working Hours: ");
                int maxWorkingHrs = Convert.ToInt32(Console.ReadLine());

                Company company = new Company() { CompanyName = companyName, EmpRatePerHour = empRatePerHr, MaxWorkingDays = maxWorkingDays, MaxWorkingHours = maxWorkingHrs };
                employee.ComputeEmpWageForCompany(company);
                //employee.ComputeEmpWageForCompany(companyName, empRatePerHr, maxWorkingDays, maxWorkingHrs);

                Console.WriteLine($"Total Employee Wage for {company.CompanyName} is {company.TotalWage}");

                Console.WriteLine("\n\tDo you want to enter another company details? (yes/no)");
                userInput = Console.ReadLine();
            }
            while (userInput.ToLower() == "yes");

        }
    }
}