using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nisha_OOPs_Accessment
{
    internal class FullTimeEmployee : Employee, IPrintable
    {
        private double sal;
        public string EType_Full
        {
            get
            {
                return EType_Full;
            }
            set
            {
                value = "Full";
            }
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public string value { get; private set; }

        public override double CalculateSalary()
        {
            double sal = BaseSalary + 5000;
            return sal;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"ID: {EmployeeId}\nName: {Name}\nType: {EType_Full}\nBase Salary: {BaseSalary}\nTotal Salary: {sal}");

        }
    }
}
