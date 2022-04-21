using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWageBuilderObject
    {
        //constance value
        const int PART_TIME_EMP = 1;
        const int FULL_TIME_EMP = 2;

        private string company_Name;
        private int emp_Wage_Pr_Hr;
        private int emp_Max_Working_Hr;
        private int emp_Working_Day_Pr_Month;
        public decimal total_Emp_Wage;
        public EmployeeWageBuilderObject(string company_Name, int emp_Wage_PR_Hr, int max_Working_Hr, int emp_Working_Days_Pr_Month)
        { 
            this.company_Name = company_Name;
            this.emp_Wage_Pr_Hr = emp_Wage_PR_Hr;
            this.emp_Max_Working_Hr = max_Working_Hr;
            this.emp_Working_Day_Pr_Month = emp_Working_Days_Pr_Month;
            this.total_Emp_Wage = total_Emp_Wage;
        }

        //variable values
        int empHrs = 0, totalEmpSalary = 0, totalEmpHrs = 0, day = 0;
             
        public void CalculateEmpWage()
        {
            while (day <= this.emp_Working_Day_Pr_Month && empHrs <= emp_Max_Working_Hr)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                
                switch (empCheck)
                {
                    case FULL_TIME_EMP:
                        empHrs +=8 ;
                        break;
                    case PART_TIME_EMP:

                        empHrs += 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                day++;
                totalEmpHrs += empHrs;
                Console.WriteLine("Days@"+emp_Working_Day_Pr_Month+"empHours "+empHrs);
            }
            totalEmpSalary = totalEmpHrs * this.emp_Wage_Pr_Hr;
            Console.WriteLine("Total Employee Wage for one Company :"+company_Name+ " " + totalEmpSalary);
        }
        public string toString()
        { 
        return "Total Employee Wage for one Company:->"+this.company_Name+"="+this.total_Emp_Wage;
        }

    }
}
