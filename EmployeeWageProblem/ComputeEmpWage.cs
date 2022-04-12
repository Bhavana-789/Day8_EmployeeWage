using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal interface ComputeEmpWage
    {
        public void AddCompanyEmpWage(string company, int empRatePerHr, int numOfWorkDays, int maxHrsPerMonth);

        public void CalculateEmpWage();
    }
}
