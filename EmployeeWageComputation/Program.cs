using System;
using EmployeeWageComputation;
class Program
{
    public static void Main(String[] args)
    {
        EmployeeWage company1 = new EmployeeWage();
        EmployeeWage company2 = new EmployeeWage();
        company1.monthlyEmpWage("google", 500, 100, 20,10,5);
        company2.monthlyEmpWage("faceBook", 600, 150, 18,6,3);
    }
}

