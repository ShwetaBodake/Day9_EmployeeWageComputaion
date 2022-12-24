using System;
namespace EmpolyeeWageComputation_Day9
{
	public class UC3_PartTimeEmployee
	{
		public void PartTimeEmployee()
		{
			int IS_PART_TIME = 2;
			int IS_FULL_TIME = 1;
			int EMP_WAGE_PER_HOUR = 20;

			int emphr = 0;
			int empWage = 0;

			Random random = new Random();
			int EMPCheck = random.Next(0, 3);

			if (EMPCheck == 1)
			{
				Console.WriteLine("Eployee is full time present");
				emphr = 8;
			}
			else if (EMPCheck == 2)
			{
				Console.WriteLine("Employee is part time present");
				emphr = 4;
			}
			else
			{	Console.WriteLine("Employee is Absent");
		}

			empWage = emphr * EMP_WAGE_PER_HOUR;
			Console.WriteLine("Daily Employee Wage " + empWage);
        }
	}
}

