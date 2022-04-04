using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem.\n");
            //UC4
            Console.WriteLine("Welcome to UC4");
            int isPartTime = 1;
            int isFullTime = 2;
            int wagePerHour = 20;
            int empHrs;
            int dailywage = 0;
            Random random = new Random();
            int EmpWorkingTime = random.Next(0, 3);

            switch (EmpWorkingTime)
            {
                case 1:
                    empHrs = 8;
                    Console.WriteLine("Employee is present for full time");
                    break;
                case 2:
                    empHrs = 4;
                    Console.WriteLine("Employee is present for part time");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            dailywage = empHrs * wagePerHour;
            Console.WriteLine("Total daily wage of employee is:");
        }
    }
}
    


