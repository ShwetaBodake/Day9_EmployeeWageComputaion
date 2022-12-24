using System;
namespace EmpolyeeWageComputation_Day9
{
	public class UC2_DailyEmployeeWage
	{
		public void DailyEmployeeWage()
		{

			//Constants
			int IS_FULL_TIME = 1;
			int EMP_WAGE_PER_HOUR = 20;

			//Variables
			int empHr = 0;
			int empWage = 0;

			Random random = new Random();
			int CheckEmp = random.Next(0, 2);

			if (CheckEmp == 1)
			{ Console.WriteLine("Employee is PRESENT");
				empHr = 8; }
			else
			{ Console.WriteLine("Employee is Absent"); }

			empWage = empHr * EMP_WAGE_PER_HOUR;
			Console.WriteLine("Daily Employee Wage is :-" + empWage);



        }
	}
}

