using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT = 1;
            Random random = new Random();
            ///If loop used to check wheather the employee is present or absent and prints it.
            if (random.Next(0, 2) == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
        /// <summary>
        /// EmpCheck method is used to generate random values 0 or 1 .
        /// denoting that 1 as present
        /// 0 as absent
        /// </summary>
        public static int EmpCheck()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
    }
}