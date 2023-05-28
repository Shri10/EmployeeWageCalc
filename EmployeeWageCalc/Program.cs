using System;

namespace EmployeeWageCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");

            Employee employee = new Employee();
            int totalWage = employee.ComputeWage();
            Console.WriteLine("\n\tEmployee Wage is: "+ totalWage);

            Console.ReadLine();
        }
    }
}