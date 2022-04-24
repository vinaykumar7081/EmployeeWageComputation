﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage: InterComputeEmpWage
    {
        //constance value
        const int PART_TIME_EMP = 1;
        const int FULL_TIME_EMP = 2;

        private  LinkedList<EmpWageBuilderObject> compEmpWageList;
        private Dictionary<string,EmpWageBuilderObject> compToEmpWageMap;
        public  EmployeeWage()
        {
            this.compEmpWageList = new LinkedList<EmpWageBuilderObject>();
            this.compToEmpWageMap = new Dictionary<string,EmpWageBuilderObject>();
        }
        public void AddCompanyEmpWage(string company_Name, int emp_Wage_PR_Hr, int max_Working_Hr, int emp_Working_Days_Pr_Month)
        {
            EmpWageBuilderObject empWageBuilderObject = new EmpWageBuilderObject(company_Name, emp_Wage_PR_Hr, max_Working_Hr, emp_Working_Days_Pr_Month);
            this.compEmpWageList.AddLast(empWageBuilderObject);
            this.compToEmpWageMap.Add(company_Name, empWageBuilderObject);  
        }
        public void ComputeEmpWage()
        {
            foreach (EmpWageBuilderObject empWageBuilderObject in this.compEmpWageList)
            {
                empWageBuilderObject.SetTotalEmpWage(this.ComputeEmpWage(empWageBuilderObject));
                Console.WriteLine(empWageBuilderObject.ToString());
            }
        }
        private int ComputeEmpWage(EmpWageBuilderObject empWageBuilderObject)
        {
            //variable values
            int empHrs = 0, totalEmpSalary = 0, totalEmpHrs = 0, day = 0;
            while (day <= empWageBuilderObject.emp_Working_Day_Pr_Month && empHrs < empWageBuilderObject.emp_Max_Working_Hr)
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
                Console.WriteLine("Days@" + empWageBuilderObject.emp_Working_Day_Pr_Month + "empHours " + empHrs);
            }
            return totalEmpSalary = totalEmpHrs * empWageBuilderObject.emp_Wage_Pr_Hr;

        }
        public int GetTotalEmpWage(string comp_Name)
        {
            return (int) this.compToEmpWageMap[comp_Name].total_Emp_Wage;
        }
    } 
}
