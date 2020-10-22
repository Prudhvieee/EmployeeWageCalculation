using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT_FULL_TIME = 1;
            int empHrs = 0;
            Random random = new Random();
            ///Here, if loop is used to check employee wage.
            ///if he is working for full time excutes the if condition 
            ///otherwise excutes else part.
            if (random.Next(0, 2) == IS_PRESENT_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            Console.WriteLine("Employee wage is " + 20 * empHrs);
        }
    }
}