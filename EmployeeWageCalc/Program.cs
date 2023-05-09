using System;

namespace EmployeeWageCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FULLTIME = 1;
            const int PARTTIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;

            Console.WriteLine("Welcome to Employee Wage Computation Program!");

            Random random = new Random();
            
            int randomInput = random.Next(0, 2);

            if (FULLTIME == randomInput)
            {
                empHrs = 8;
                Console.WriteLine("Fulltime Employee is present");
            }
            else if (PARTTIME == randomInput)
            {
                empHrs = 4;
                Console.WriteLine("Parttime Employee is present");
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
