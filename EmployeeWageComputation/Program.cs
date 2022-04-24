using System;
using EmployeeWageComputation;
class Program
{
    public static void Main(String[] args)
    {
        EmployeeWage company = new EmployeeWage();
        Console.WriteLine("Enter the Company_Name \n EmpWage_Working_Pr_Hours \n Total_Working_Hours \n Total_Working_Das_In_Month");
        string comp_Name=Console.ReadLine();
        int EmpWage_Working_Pr_Hours=Convert.ToInt32(Console.ReadLine());
        int Total_Working_Hours=Convert.ToInt32(Console.ReadLine());
        int Total_Working_Das_In_Month=Convert.ToInt32(Console.ReadLine());
        company.AddCompanyEmpWage(comp_Name, EmpWage_Working_Pr_Hours, Total_Working_Hours, Total_Working_Das_In_Month);
        //company.AddCompanyEmpWage(comp_Name, EmpWage_Working_Pr_Hours, Total_Working_Hours, Total_Working_Das_In_Month);
        company.ComputeEmpWage();
        Console.WriteLine("Total wage for"+ comp_Name +":"+" "+company.GetTotalEmpWage(comp_Name));
    }
}

