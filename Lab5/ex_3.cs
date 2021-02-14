using System;

namespace Lab5_3
{
    class ex_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter eps: ");
            double eps = double.Parse(Console.ReadLine());
            double el = 0, sum = 0;
            int x = 1;


            while (sum < eps)
            {
                el = Math.Sin(x) / x;
                sum += el;
            }

            Console.WriteLine(sum.ToString());
        }
    }
}
