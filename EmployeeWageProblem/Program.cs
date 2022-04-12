using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem.\n");
            /*//UC8_MultipleCompanyEmpWage
            UC8_MultipleCompanies.CalculateEmpWage("Samsung", 20, 5, 30);
            UC8_MultipleCompanies.CalculateEmpWage("Jio", 10, 4, 20);


            //UC9_SaveTotalWages
            UC9_SaveTotalWage obj = new UC9_SaveTotalWage("Samsung", 20, 100, 20);
            obj.ComputeEmployeeWage();
            Console.WriteLine(obj.toString());
            UC9_SaveTotalWage obj1 = new UC9_SaveTotalWage("Jio", 10, 120, 21);
            obj1.ComputeEmployeeWage();
            Console.WriteLine(obj1.toString());*/

            //UC10_ManageEmployeeWage
             Uc10_ManageEmployeeWage manager = new();

            manager.AddCompanyEmpWage("Samsung", 20, 5, 30);
            manager.AddCompanyEmpWage("Jio", 10, 4, 20);

            manager.CalculateEmpWage();

        }
    }
}
    


