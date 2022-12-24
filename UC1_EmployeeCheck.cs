using System;
namespace EmpolyeeWageComputation_Day9
{
	public class UC1_EmployeeCheck
	{
		public void EmployeeCheck()
		{
			int IS_FULL_TIME = 1;

			Random random = new Random();
			int EMP_Check = random.Next(0, 2);

			if (EMP_Check == 1)
			{
				Console.WriteLine("Employee is Present");
			}
			else
				Console.WriteLine("Employee is Absent.");
		}
	}
}

