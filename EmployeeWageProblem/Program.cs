using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem.\n");
            //UC8_MultipleCompanyEmpWage
            Console.WriteLine("Welcome to UC");
            UC8_MultipleCompanies.CalculateEmpWage("Samsung", 20, 5, 30);
            UC8_MultipleCompanies.CalculateEmpWage("Jio", 10, 4, 20);
        }
    }
}
    


