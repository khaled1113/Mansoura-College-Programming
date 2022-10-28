using System;

namespace The_area_of_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, s, area;
            Console.Write("Enter A : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter B : ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter C : ");
            c = double.Parse(Console.ReadLine());
            s = (a + b + c) / 2.0;
            area = Math.Sqrt((s * (s - a) * (s - b) * (s - c)));
            Console.WriteLine("The Area is = " + area);
        }
    }
}
