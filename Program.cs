using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT_PART_TIME = 1;
            const int IS_PRESENT_FULL_TIME = 2;
            const int IS_ABSENT = 0;
            const int EMP_RATE_PER_HOUR = 20;
            const int NUM_OF_WORKING_DAYS = 20;
            int empHrs = 0;
            int empwage = 0;
            int totalEmpWage = 0;
            ///Here, switch case statement is used to check employee wage.
            ///if he present then it executes the switch case 1
            ///if he absent then it executes the switch case 2
            Random random = new Random();
            for (int day = 1; day <= NUM_OF_WORKING_DAYS; day++)
            {
                switch (random.Next(0, 3))
                {
                    case IS_PRESENT_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_PRESENT_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_ABSENT:
                        empHrs = 0;
                        break;
                }
                empwage = EMP_RATE_PER_HOUR * empHrs;
                totalEmpWage += empwage;
                Console.WriteLine("Employee wage of  day " + day + " is " + empwage);
            }
            Console.WriteLine("total employee wage for a month " + totalEmpWage);

        }
    }
}