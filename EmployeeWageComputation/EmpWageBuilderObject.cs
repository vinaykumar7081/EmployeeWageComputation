using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilderObject
    {
        public string Company_Name { get; set; }
        public int Emp_Wage_Pr_Hr { get; set; }
        public int Emp_Max_Working_Hr { get; set; }
        public int Emp_Working_Day_Pr_Month { get; set; }
        public decimal Total_Emp_Wage { get; set; }
       
    }
}
