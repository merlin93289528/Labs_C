using System;
using System.Linq;

namespace Lab4
{
    class ex_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coords A: ");
            double[] A_dot = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine("Enter coords B: ");
            double[] B_dot = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine("Enter coords C: ");
            double[] C_dot = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine("Enter coords D: ");
            double[] D_dot = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double AB_line = Math.Sqrt(Math.Pow((A_dot[0] - B_dot[0]), 2.0) + Math.Pow((A_dot[1] - B_dot[1]), 2.0) + Math.Pow((A_dot[2] - B_dot[2]), 2.0));
            double BC_line = Math.Sqrt(Math.Pow((B_dot[0] - C_dot[0]), 2.0) + Math.Pow((B_dot[1] - C_dot[1]), 2.0) + Math.Pow((B_dot[2] - C_dot[2]), 2.0));
            double CD_line = Math.Sqrt(Math.Pow((C_dot[0] - D_dot[0]), 2.0) + Math.Pow((C_dot[1] - D_dot[1]), 2.0) + Math.Pow((C_dot[2] - D_dot[2]), 2.0));
            double DA_line = Math.Sqrt(Math.Pow((D_dot[0] - A_dot[0]), 2.0) + Math.Pow((D_dot[1] - A_dot[1]), 2.0) + Math.Pow((D_dot[2] - A_dot[2]), 2.0));

            double AC_line = Math.Sqrt(Math.Pow((A_dot[0] - C_dot[0]), 2.0) + Math.Pow((A_dot[1] - C_dot[1]), 2.0) + Math.Pow((A_dot[2] - C_dot[2]), 2.0));
            double BD_line = Math.Sqrt(Math.Pow((B_dot[0] - D_dot[0]), 2.0) + Math.Pow((B_dot[1] - D_dot[1]), 2.0) + Math.Pow((B_dot[2] - D_dot[2]), 2.0));

            if (AB_line == BC_line && BC_line == CD_line && CD_line == DA_line && DA_line == AB_line && AC_line != BD_line)
            {
                Console.WriteLine("ABCD - rhombus");
            } else
            {
                Console.WriteLine("ABCD is not rhombus");
            }
        }
    }
}
