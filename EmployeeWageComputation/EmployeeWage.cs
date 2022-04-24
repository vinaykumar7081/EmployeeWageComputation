using System;
using System.Collections.Generic;
using System.Collections;
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
        int empHrs = 0, totalEmpSalary = 0, totalEmpHrs = 0, day = 0, dailyEmpWage=0;
        ArrayList compEmpWageList = new ArrayList();
        public EmployeeWage()
        {
            Console.WriteLine("Enter the Company_Name \n EmpWage_Working_Pr_Hours \n Total_Working_Hours \n Total_Working_Das_In_Month");
            EmpWageBuilderObject company1 = new EmpWageBuilderObject()
            {
                Company_Name = Console.ReadLine(),
                Emp_Wage_Pr_Hr = Convert.ToInt32(Console.ReadLine()),
                Emp_Max_Working_Hr = Convert.ToInt32(Console.ReadLine()),
                Emp_Working_Day_Pr_Month = Convert.ToInt32(Console.ReadLine()),
                Total_Emp_Wage = 0,
                DailyEmployeeSalary =0
            };
            Console.WriteLine("Enter the Company_Name \n EmpWage_Working_Pr_Hours \n Total_Working_Hours \n Total_Working_Das_In_Month");
            EmpWageBuilderObject company2 = new EmpWageBuilderObject()
            {
                Company_Name = Console.ReadLine(),
                Emp_Wage_Pr_Hr = Convert.ToInt32(Console.ReadLine()),
                Emp_Max_Working_Hr = Convert.ToInt32(Console.ReadLine()),
                Emp_Working_Day_Pr_Month = Convert.ToInt32(Console.ReadLine()),
                Total_Emp_Wage = 0,
                DailyEmployeeSalary = 0
            };
            compEmpWageList.Add(company1);
            compEmpWageList.Add(company2);
        }
        public void ComputeEmpWage()
        {
            foreach (EmpWageBuilderObject empWageBuilderObject in this.compEmpWageList)
            {
                this.ComputeEmpWage(empWageBuilderObject);
                empWageBuilderObject.Total_Emp_Wage = this.totalEmpSalary;
                empWageBuilderObject.DailyEmployeeSalary = this.dailyEmpWage;
                Console.WriteLine("Total Employee salary of One Employee  " + empWageBuilderObject.Total_Emp_Wage);
            }
        }
        private void ComputeEmpWage(EmpWageBuilderObject empWageBuilderObject)
        {
            while (day <= empWageBuilderObject.Emp_Working_Day_Pr_Month && empHrs < empWageBuilderObject.Emp_Max_Working_Hr)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case FULL_TIME_EMP:
                        empHrs += 8;
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
                Console.WriteLine("Days@" + empWageBuilderObject.Emp_Working_Day_Pr_Month + "empHours " + empHrs);
                int dailyEmpWage = totalEmpHrs * empWageBuilderObject.Emp_Wage_Pr_Hr;
                Console.WriteLine("Daily EmployeeWage of A Company:-->" +dailyEmpWage);
            }
            totalEmpSalary = totalEmpHrs * empWageBuilderObject.Emp_Wage_Pr_Hr;

        }
    }   
}
