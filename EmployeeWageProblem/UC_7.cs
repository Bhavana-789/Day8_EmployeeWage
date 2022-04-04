using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class UC_7
    {
        const int IsAbsent = 0;
        const int IsFullTime = 1;
        const int IsPartTime = 2;
        const int WagePerHr = 20;
        const int FullTimeHr = 8;
        const int PartTimeHr = 4;
        const int MaxWorkDays = 20;
        const int MaxEmpHrs = 100;

        public static void CalculateEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkDays = 0;
            while (totalWorkDays < MaxWorkDays && totalEmpHrs < MaxEmpHrs)
            {
                totalWorkDays++;
                Random random = new Random();
                int randomCheck = random.Next(3);
                switch (randomCheck)
                {
                    case IsFullTime:
                        empHrs = FullTimeHr;
                        break;
                    case IsPartTime:
                        empHrs = PartTimeHr;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                totalWorkDays++;
            }
            int empWage = totalEmpHrs * WagePerHr;

            Console.WriteLine("Total working Day is: " + totalWorkDays);
            Console.WriteLine("Total Working Hours is: " + totalEmpHrs + "\n");
            Console.WriteLine("And the Employee Wage for the month is: " + empWage + "\n");
        }
    }
}

