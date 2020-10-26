using EmployeeWageCalculation;
using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBuilderArray employeeBuilderArray = new EmployeeBuilderArray();
            employeeBuilderArray.AddCompanyEmpWage("IBM", 50, 20, 100);
            employeeBuilderArray.AddCompanyEmpWage("HM", 60, 20, 110);
            employeeBuilderArray.ComputeEmployeeWage();
        }
    }
}