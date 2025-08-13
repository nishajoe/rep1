using Nisha_OOPs_Accessment;

internal class Program
{
    private static void Main(string[] args)
    {
        FullTimeEmployee fEmp = new FullTimeEmployee();
        PartTimeEmployee pEmp = new PartTimeEmployee();
       

        Console.WriteLine("Enter the type of Employee (Full/Part): ");
        string check= Console.ReadLine();
        if(check=="Full" || check== "full")
        {
            Console.WriteLine("Enter Employee ID: ");
            fEmp.EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            fEmp.Name = Console.ReadLine();
            Console.WriteLine("Enter Base Salary: ");
            fEmp.BaseSalary = Convert.ToDouble(Console.ReadLine());
            fEmp.CalculateSalary();
            fEmp.PrintDetails();
        }
        else
        {
            Console.WriteLine("Enter Employee ID: ");
            pEmp.EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            pEmp.Name = Console.ReadLine();
            Console.WriteLine("Enter Base Salary: ");
            pEmp.BaseSalary = Convert.ToDouble(Console.ReadLine());
       
            pEmp.CalculateSalary(); 
            pEmp.PrintDetails();
        }
    }
}