using System;

namespace Student_GPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            double Math, phis, Mech, Programing, Electrical, Average;
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Math Score : ");
            Math = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mech Score : ");
            Mech = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Phis Score : ");
            phis = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Programming Score :");
            Programing = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Electric Score : ");
            Electrical = double.Parse(Console.ReadLine());
            Average = (Math + Mech + phis + Programing + Electrical) / 5;
            if (Average >= 97)
                Console.WriteLine(name + " Grade= A+ and GPA is 4");
            else if (Average >= 93 && Average < 97)
                Console.WriteLine(name + " Grade= A and GPA is 4");
            else if (Average >= 89 && Average < 93)
                Console.WriteLine(name + " Grade= A- and GPA is 3.7");
            else if (Average >= 84 && Average < 89)
                Console.WriteLine(name + " Grade= B+ and GPA is 3.3");
            else if (Average >= 80 && Average < 84)
                Console.WriteLine(name + " Grade= B and GPA is 3.0");
            else if (Average >= 76 && Average < 80)
                Console.WriteLine(name + " Grade= B- and GPA is 2.7");
            else if (Average >= 73 && Average < 76)
                Console.WriteLine(name + " Grade= C+ and GPA is 2.3");
            else if (Average >= 70 && Average < 73)
                Console.WriteLine(name + " Grade= C and GPA is 2.0");
            else if (Average >= 67 && Average < 70)
                Console.WriteLine(name + " Grade= C- and GPA is 1.7");
            else if (Average >= 64 && Average < 67)
                Console.WriteLine(name + " Grade= D+ and GPA is 1.3");
            else if (Average >= 60 && Average < 64)
                Console.WriteLine(name + " Grade= D and GPA is 1.0");
            else if (Average < 60)
                Console.WriteLine(name + " Grade= F and GPA is 0");
        }
    }
}
