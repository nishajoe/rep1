using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nisha_OOPs_Accessment
{
    internal class PartTimeEmployee : Employee, IPrintable
    {
        private double sal;
       
        public string EType_Part
        {
            get
            {
                return EType_Part;
            }
            set
            {
                value = "Part";
            }
        }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public override double CalculateSalary()
        {
            double sal = BaseSalary + 2000;
            return sal;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"ID: {EmployeeId}\nName: {Name}\nType: {EType_Part}\nBase Salary: {BaseSalary}\nTotal Salary: {sal}");

        }
    }
}
