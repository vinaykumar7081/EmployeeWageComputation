using System;
using EmployeeWageComputation;
class Program
{
    public static void Main(String[] args)
    {
        EmployeeWage company = new EmployeeWage();
        
        company.AddCompanyEmpWage("google", 500, 100, 20);
        company.AddCompanyEmpWage("faceBook", 600, 150, 18);
        company.ComputeEmpWage();
        Console.WriteLine(company.ToString());
    }
}

