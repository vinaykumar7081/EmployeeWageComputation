using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilderObject
    {
        public string company_Name;
        public int emp_Wage_Pr_Hr;
        public int emp_Max_Working_Hr;
        public int emp_Working_Day_Pr_Month;
        public decimal total_Emp_Wage;
        public EmpWageBuilderObject(string company_Name, int emp_Wage_PR_Hr, int max_Working_Hr, int emp_Working_Days_Pr_Month)
        {
            this.company_Name = company_Name;
            this.emp_Wage_Pr_Hr = emp_Wage_PR_Hr;
            this.emp_Max_Working_Hr = max_Working_Hr;
            this.emp_Working_Day_Pr_Month = emp_Working_Days_Pr_Month;
            this.total_Emp_Wage = 0;
        }
        public void SetTotalEmpWage(int total_Emp_Wage)
        { 
        this.total_Emp_Wage = total_Emp_Wage;
        }
        public string toString()
        {
            return "Total Employee wage for Company:-->" +this.company_Name+ "="+this.total_Emp_Wage;
        }

    }
}
