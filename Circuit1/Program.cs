using System;

namespace Circuit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R1, R2, R3, Vs, I1 = 0, I2 = 0, I3 = 0, Req;
            int Key;
            Console.WriteLine("Enter Vs = ");
            Vs = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter R1");
            R1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter R2");
            R2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter R3");
            R3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Key Satus");
            Key = int.Parse(Console.ReadLine());
            if (Key == 0)
            {
                I1 = Vs / (R1 + R2);
                I2 = 0;
                I3 = I1;
            }
            else if (Key == 1)
            {
                Req = (R2 * R3) / (R2 + R3);
                I1 = Vs / (R1 + Req);
                I2 = (R3 / (R2 + R3)) * I1;
                I3 = (R2 / (R2 + R3)) * I1;
            }
            Console.WriteLine("I1 = " + I1 + " A");
            Console.WriteLine("I2 = " + I2 + " A");
            Console.WriteLine("I3 = " + I3 + " A");
        }
    }
}
