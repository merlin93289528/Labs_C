using System;
using System.Linq;

namespace Lab5_2
{
    class ex_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int[] numArr = Console.ReadLine().ToArray().Select(x => (int)x).ToArray();

            int pr = 0;
            bool isConsistent = true;

            foreach (int el in numArr)
            {
                if (el < pr)
                {
                    isConsistent = false;
                    break;
                }
                pr = el;
            }

            Console.WriteLine(isConsistent.ToString());
        }
    }
}
