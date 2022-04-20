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
        const int PART_TIME_EMP = 1;
        const int FULL_TIME_EMP = 2;
            
        //variable values
        int empHrs = 0, totalEmpSalary = 0, totalEmpHrs = 0, day = 0;
             
        public void monthlyEmpWage(string company_Name,int emp_Wage_Pr_Hr,int max_Working_Hr,int emp_Working_Days_Pr_Month,int emp_Full_Day_Working_Hr, int emp_Part_Time_Working_Hr)
        {
            while (day <= emp_Working_Days_Pr_Month && empHrs <= max_Working_Hr)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                
                switch (empCheck)
                {
                    case FULL_TIME_EMP:

                        empHrs += emp_Full_Day_Working_Hr;
                        break;
                    case PART_TIME_EMP:

                        empHrs += emp_Part_Time_Working_Hr;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                day++;
            }
            totalEmpSalary = empHrs * emp_Wage_Pr_Hr;
            Console.WriteLine("One month Employee Salary is :" + totalEmpSalary);
        }
       

    }
}
