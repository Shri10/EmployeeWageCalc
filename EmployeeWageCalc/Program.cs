using System;

namespace EmployeeWageCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_FULLTIME = 1;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;

            Console.WriteLine("Welcome to Employee Wage Computation Program!");

            Random random = new Random();
            
            int randomInput = random.Next(0, 2);

            if (IS_FULLTIME == randomInput)
            {
                empHrs = 8;
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage Per Day: {0}", empWage);

            Console.ReadLine();

        }
    }
}
