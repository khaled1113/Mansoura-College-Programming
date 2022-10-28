using System;

namespace net_salary_of_employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            double salary, Net_Salary;
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Salary : ");
            salary = double.Parse(Console.ReadLine());
            Net_Salary = salary + 0.1 * salary - 0.05 * salary;
            Console.WriteLine("The Net Salary of " + name + " is " + Net_Salary);
        }
    }
}
