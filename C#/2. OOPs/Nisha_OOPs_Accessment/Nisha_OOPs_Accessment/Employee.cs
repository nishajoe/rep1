using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nisha_OOPs_Accessment
{
    public abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public abstract double CalculateSalary();

    }
}


