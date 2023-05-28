using System;

namespace EmployeeWageCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");

            //Employee employee  = new Employee();
            /* Syntax Refernce
             * ComputeEmpWageForCompany(string companyName, int EMP_RATE_PER_HR, int MAX_WORKING_DAYS, int MAX_WORKING_HOURS)
             */
            /*
                        employee.ComputeEmpWageForCompany("BridgeLabz", 20, 20, 100);
                        employee.ComputeEmpWageForCompany("Micros", 25, 25, 120);
            */
            //var employee = new Employee();
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

                employee.ComputeEmpWageForCompany(companyName, empRatePerHr, maxWorkingDays, maxWorkingHrs);

                Console.WriteLine("\n\tDo you want to enter another company details? (yes/no)");
                userInput = Console.ReadLine();
            }
            while (userInput.ToLower() == "yes");

            //Console.ReadLine();
        }
    }
}