using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem.\n");
            //UC3
            Console.WriteLine("Welcome to UC3");
            int totalWorkingHour = 8;
            int partTimeHour = 4;
            int wagePerHour = 20;
            int dailywage = 0;
            Random random = new Random();
            int EmpWorkingTime = random.Next(0, 3);
            if (EmpWorkingTime == 0)
            {
                Console.WriteLine("Employee is present for full time");
                dailywage = totalWorkingHour * wagePerHour;
                Console.WriteLine("Total Daily wage is:" + dailywage);
            }
            else if (EmpWorkingTime == 1)
            {
                Console.WriteLine("Employee is present for part time");
                dailywage = partTimeHour * wagePerHour;
                Console.WriteLine("Total Daily Wage is:" + dailywage);
            }
            else
            {
                Console.WriteLine("Employee is absent");
                Console.WriteLine("Total Daily Wage is:" + dailywage);
            }
        }
    }
}

