using System;

namespace ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            int y;

            switch (n)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    y = 0;
                    break;
                case 10:
                case 11:
                case 12:
                    y = 1;
                    break;
                case 15:
                case 19:
                    y = 2;
                    break;
                default:
                    y = 3;
                    break;
            }

            Console.WriteLine($"y = {y}");
        }
    }
}
