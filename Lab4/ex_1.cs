using System;
using System.Linq;

namespace Lab_4
{
    class ex_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter vector X: ");
            double[] first_v = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine("Enter vector Y: ");
            double[] second_v = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double scalar = first_v[0] * second_v[0] + first_v[1] * second_v[1] + first_v[2] * second_v[2];

            double[] z = { first_v[0] * scalar, first_v[1] * scalar, first_v[2] * scalar };

            foreach (double el in z) {
                Console.Write($"{el.ToString()} ");
            };

        }
    }
}
