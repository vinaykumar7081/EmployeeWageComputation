using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        //constance value
        const int EMP_WAGE_PR_HR = 20;
        const int EMP_FULL_DAY_WRKING_HR = 8;
        const int IS_PRESENT = 1;
        //variable values
        int empHrs = 0;
        int oneDayEmpSalary=0;
        public void empAttandence()
        {   
            Random random = new Random();
            int empCheck=random.Next(0,2);
           
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        public void dailyEmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                empHrs = 8;
            }
            else
            {
                empHrs=0;
            }
            oneDayEmpSalary = empHrs * EMP_WAGE_PR_HR;
            Console.WriteLine("One Day Employee salary is :" + oneDayEmpSalary);
        }
    }
}
