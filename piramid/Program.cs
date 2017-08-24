using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piramid
{
    class Program
    {
        static void MakePyramid (int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int m = i; m<=n; m++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < 2*i-1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            MakePyramid(6);
            Console.ReadKey();
        }
    }
}
