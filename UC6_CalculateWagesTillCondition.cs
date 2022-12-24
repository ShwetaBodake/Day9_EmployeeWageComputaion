using System;
namespace EmpolyeeWageComputation_Day9
{
	public class UC6_CalculateWagesTillCondition
	{
        public const int IS_PART_TIME = 2;
        public const int IS_FULL_TIME = 1;
        public const int EMP_Wage_PER_HOUR = 20;
        public const int TotalDaysInMonth = 20;
        public const int MAX_Hrs_In_Month =100;

        public void CalculateWagesTillCondition()
		{
           int emphr = 0;
            int totalempHrs = 0;
            int totalworkingdays = 0;

            while (totalempHrs <= MAX_Hrs_In_Month && totalworkingdays < TotalDaysInMonth)
            {
                totalworkingdays++;

                Random random = new Random();
                int CheckEmp = random.Next(0, 3);

                switch (CheckEmp)
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
                totalempHrs += emphr;
                Console.WriteLine("Day" + totalworkingdays + "emphrs" + emphr);
            }
            int totalempWage = totalempHrs * EMP_Wage_PER_HOUR;
            Console.WriteLine("Total Wage of employee" + totalempWage);





        }
	}
}

