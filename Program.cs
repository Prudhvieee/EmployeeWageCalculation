using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageBuilder apple = new EmployeeWageBuilder("Apple", 50, 20, 100);
            EmployeeWageBuilder google = new EmployeeWageBuilder("Google", 60, 20, 110);
            apple.ComputeEmployeeWage();
            Console.WriteLine(apple.toString());
            google.ComputeEmployeeWage();
            Console.WriteLine(google.toString());
        }
    }
}