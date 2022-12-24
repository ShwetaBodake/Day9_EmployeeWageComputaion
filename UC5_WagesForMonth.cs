using System;
namespace EmpolyeeWageComputation_Day9
{
	public class UC5_WagesForMonth
	{
        public const int IS_PART_TIME = 2;
        public const int IS_FULL_TIME = 1;
        public const int EMP_Wage_PER_HOUR = 20;
        public const int TotalDaysInMonth = 20;
		
        public void WagesForMonth()
		{
            int emphr = 0;
            int empWage = 0;
            int TotalMonthWage = 0;

            Random random = new Random();
            int CheckEmp = random.Next(0, 3);

            switch(CheckEmp)
            {
                case IS_FULL_TIME:
                    emphr = 8;
                    break;

                case IS_PART_TIME:
                    emphr = 4;
                    break;
                default:
                    emphr = 0;
                    break;
            }
            empWage = emphr * EMP_Wage_PER_HOUR;
            TotalMonthWage = empWage * TotalDaysInMonth;
            Console.WriteLine("Total wage for month " + TotalMonthWage);


        }
	}
}

