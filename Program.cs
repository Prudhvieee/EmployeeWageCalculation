using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT_PART_TIME = 1;
            const int IS_PRESENT_FULL_TIME = 2;
            int empHrs = 0;
            ///Here, if loop is used to check employee wage.
            ///if he is working for full time excutes the if condition 
            ///otherwise excutes else part.
            Random random = new Random();
            if (random.Next(0, 3) == IS_PRESENT_PART_TIME)
            {
                Console.WriteLine("Employee is present for part time");
                empHrs = 4;
            }
            else if (random.Next(0, 3) == IS_PRESENT_FULL_TIME)
            {
                Console.WriteLine("Employee is present for Full time");
                empHrs = 8;
            }
            else
                Console.WriteLine("Employee is Absent");
            Console.WriteLine("Employee wage is " + 20 * empHrs);
        }
    }
}