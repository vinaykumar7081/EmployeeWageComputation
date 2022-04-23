using System;
using EmployeeWageComputation;
class Program
{
    public static void Main(String[] args)
    {
        EmployeeWage company1 = new EmployeeWage("google", 500, 100, 20);
        EmployeeWage company2 = new EmployeeWage("faceBook", 600, 150, 18);
        company1.CalculateEmpWage();
        Console.WriteLine(company1.toString());
        company2.CalculateEmpWage();
        Console.WriteLine(company2.toString());
    }
}

