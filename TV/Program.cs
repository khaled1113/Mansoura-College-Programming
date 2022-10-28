using System;

namespace TV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            double price = 0;
            Console.WriteLine("Enter the Size of the TV");
            size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Price of the TV");
            price = Double.Parse(Console.ReadLine());
            if (size == 12)
                price *= .95;
            else if (size == 16)
                price *= .9;
            else if (size == 18)
                price *= .85;
            else
                Console.WriteLine("Sorry There is no discount for this TV");
            Console.WriteLine("The new Pricw for this TV is {0} ", price);
        }
    }
}
