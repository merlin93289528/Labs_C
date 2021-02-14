
using System;

namespace Lab4
{
    class ex_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X = ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Y = ");
            double y = double.Parse(Console.ReadLine());

            if (x > y)
            {
                x = (x + y) / 2;
            } else
            {
                y = Math.Pow(y, 2.0);
            }

            Console.WriteLine($"{x.ToString()} {y.ToString()}");
        }
    }
}
