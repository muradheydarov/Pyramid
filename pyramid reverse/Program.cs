using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramid_reverse
{
    class Program
    {
        static void ReversePyramid(int n)
        {
            for (int i = n; i <= n && i >=0; i--)
            {
                for (int m = n; m >= i && m>=0; m--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            ReversePyramid(6);
            Console.ReadKey();
        }
    }

}
