using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem.\n");
            //UC6_WagesTillCondition
            Console.WriteLine("Welcome to UC6");
            int isPartTime = 1;
            int isFullTime = 2;
            int totalWorkingHrs = 0;
            int wagePerHour = 20;
            int totalWage = 0;
            int totalWorkingDays = 1, empHrs;
            int totalWorkingLimit = 100;

            while (totalWorkingDays <= 20 && totalWorkingHrs <= totalWorkingLimit)
            {
                Random random = new Random();
                int randomCheck = random.Next(0, 3);
                switch (randomCheck)
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
                totalWorkingDays++;
                totalWorkingHrs = totalWorkingHrs + empHrs;
            }
            totalWage = wagePerHour * totalWorkingHrs;
            Console.WriteLine("Total wage is:" + totalWage);
        }
    }
}
    


