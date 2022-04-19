using System;
using EmployeeWageComputation;
class Program
{
    public static void Main(String[] args)
    {
        EmployeeWage computation = new EmployeeWage();
        Console.WriteLine("Enter the Compnay Name");
        string comp_Name=Console .ReadLine();
        Console.WriteLine("Enter the Employee Salary Pr Hours");
        int emp_Wage_Pr_Hours=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Maximum Working Hours Of That Company");
        int max_Working_Hour = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Working Days in One Month");
        int working_Days_In_One_Month = Convert.ToInt32(Console.ReadLine());
        computation.monthlyEmpWage(comp_Name, emp_Wage_Pr_Hours, max_Working_Hour, working_Days_In_One_Month);
    }
}

