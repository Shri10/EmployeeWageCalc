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
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HOURS = 100;
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int totalWrkHrs = 0;

            Console.WriteLine("Welcome to Employee Wage Computation Program!");

            Random random = new Random();

            while ( day<= MAX_WORKING_DAYS && totalWrkHrs <= MAX_WORKING_HOURS)
            {
                Console.WriteLine("\n\tDay {0}\n", day);

                int randomInput = random.Next(0, 3);

                switch (randomInput)
                {
                    case FULLTIME:
                        empHrs = 8;
                        Console.WriteLine("Fulltime Employee is present");
                        break;
                    case PARTTIME:
                        empHrs = 4;
                        Console.WriteLine("Parttime Employee is present");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }

                empWage = EMP_RATE_PER_HR * empHrs;
                Console.WriteLine("Employee Wage for Day {0}: {1}", day, empWage);
                day++;
                totalWage += empWage;
                totalWrkHrs += empHrs;
            }

            Console.WriteLine("\n\nEmployee Wage for {0} Days & {1} Hours is: {2}", day-1, totalWrkHrs, totalWage);
            Console.ReadLine();

        }
    }
}