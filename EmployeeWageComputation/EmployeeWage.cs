using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1;
        public void empAttandence()
        {
            Random random = new Random();
            int empCheck=random.Next(0,2);
            if (empCheck == 1)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
