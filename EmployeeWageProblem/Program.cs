using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem.\n");
            //UC2
            Console.WriteLine("Welcome to UC2");
            int totalWorkingHour = 8;
            int wagePerHour = 20;
            int dailyWage = 0;
            Random random = new Random();
            int num = random.Next(0, 2);
            if (num == 0)
            {
                Console.WriteLine("Employee is Present");
                dailyWage = totalWorkingHour * wagePerHour;
                Console.WriteLine("Total Daily wage is:" + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Total daily wage is:" + dailyWage);
            }
        }
    }
}

