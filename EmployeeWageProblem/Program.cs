using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem.\n");
            //UC5_MonthlyWage
            Console.WriteLine("Welcome to UC5");
            int isPartTime = 1;
            int isFullTime = 2;
            int wagePerHour = 20;
            int empHrs;
            int dailywage = 0;
            int totalWorkingHour = 0;
            int numOfWorkingDays = 20;
            while (numOfWorkingDays > 0)
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
                numOfWorkingDays--;
                totalWorkingHour = totalWorkingHour + empHrs;
            }
            dailywage = totalWorkingHour * wagePerHour;
            Console.WriteLine("Total wage is:" + dailywage);
        }
    }
}
    


