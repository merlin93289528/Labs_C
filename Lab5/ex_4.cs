using System;

namespace Lab5_4
{
    class ex_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int x = Formula(int.Parse(Console.ReadLine()));

            Console.WriteLine(x.ToString());
        }

        static int Formula(int n)
        {
            if (n == 0)
            {
                return 2;
            } else if (n == 1 || n == 2) 
            {
                return 3;
            } else
            {
                return 7 * Formula(n - 1) - Formula(n - 2) * Formula(n - 3); 
            }
        }
    }
}
