using System;
using EmployeeWageComputation;
class Program
{
    public static void Main(String[] args)
    {
        EmployeeWageBuilderObject company1 = new EmployeeWageBuilderObject("google", 500, 100, 20);
        EmployeeWageBuilderObject company2 = new EmployeeWageBuilderObject("faceBook", 600, 150, 18);
        company1.CalculateEmpWage();
        Console.WriteLine(company1.toString());
        company2.CalculateEmpWage();
        Console.WriteLine(company2.toString());
    }
}

