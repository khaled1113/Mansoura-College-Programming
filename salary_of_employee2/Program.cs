using System;

namespace salary_of_employee2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Salary, tax = 0, Over = 0, Net_Salary = 0;
            string Emp_Name;
            Console.Write("Enter the employee name");
            Emp_Name = Console.ReadLine();
            Console.WriteLine("Enter the employee salary");
            Salary = double.Parse(Console.ReadLine());
            if (Salary <= 500)
            {
                Net_Salary = Salary;
                tax = 0;
                Over = 0;
            }
            else if (Salary > 500)
            {
                tax = Salary * 0.15;
                Over = Salary * 0.02;
                Net_Salary = Salary + Over - tax;
            }
            Console.WriteLine("the Data of " + Emp_Name + " as following the Net Salary is : " + Net_Salary + " the Tax is : " + tax + " the Over is : " + Over);
        }
    }
}
