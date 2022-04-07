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
        const int EMP_WAGE_PR_HR = 20;
        const int EMP_FULL_DAY_WRKING_HR = 8;
        const int EMP_PART_TIME_WRKING_HR = 4;
        const int EMP_WORKING_PR_MONTH= 20;
        const int MAX_WORKING_HR = 100;
         
       
        //variable values
        int empHrs = 0;
        int totalEmpSalary=0;
        int totalEmpHrs = 0;
        int day = 0;
      
        public void monthlyEmpWage()
        {
            while (day <= EMP_WORKING_PR_MONTH && empHrs <= MAX_WORKING_HR)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                
                switch (empCheck)
                {
                    case FULL_TIME_EMP:

                        empHrs += EMP_FULL_DAY_WRKING_HR;
                        break;
                    case PART_TIME_EMP:

                        empHrs += EMP_PART_TIME_WRKING_HR;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                day++;

            }

            totalEmpSalary = empHrs * EMP_WAGE_PR_HR;
            Console.WriteLine("One month Employee Salary is :" + totalEmpSalary);
        }
       

    }
}
