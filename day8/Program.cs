namespace EmployeWageMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome Employee Wages");
            Console.WriteLine("Choose Option\n 1. Check absent present\n2. daily wages\n3. part time wages\n4. switch loop\n5. monthly wages\n6. Monthly Wages using while loop\n7. emp wages");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    EmployeePresentAbsent.EmployeeAttendance();
                    break;
                case 2:
                    DailyWage.CalculateDailyWage();
                    break;
                case 3:
                    PartTimeFullTime.CalculatePercentage();
                    break;
                case 4:
                    SwitchCase.CalculateWage();
                    break;
                case 5:
                    WageMonthly.CalculateWageForMonth();
                    break;
                case 6:
                    WagesWhileLoop.CalculateWage();
                    break;
                case 7:
                    ComputeEmpWage.ComputeEmp();
                    break;

            }
        }
    }
}