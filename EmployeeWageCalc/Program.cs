﻿using System;

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
            int empHrs = 0;
            int empWage = 0;

            Console.WriteLine("Welcome to Employee Wage Computation Program!");

            Random random = new Random();

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
                    Console.WriteLine("Employee is absent");
                    break;
            }

            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage Per Day: {0}", empWage);

            Console.ReadLine();

        }
    }
}