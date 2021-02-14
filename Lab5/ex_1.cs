using System;

namespace Lab5_1
{
    class ex_1
    {
        static void Main(string[] args)
        {
            int x;
            double y, sum;

            for (x = 1, y = 0.1, sum = 0; x < 10; sum += x + Math.Cos(y), x++, y+=0.1) {}

            Console.WriteLine(sum.ToString());
        }
    }
}
